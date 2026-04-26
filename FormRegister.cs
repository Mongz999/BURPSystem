using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BURPSystem
{
    public partial class FormRegister : Form
    {
        OleDbConnection conn;

        void ConnectDB()
        {
            string path = Application.StartupPath + @"\CanteenDB.accdb";
            conn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
        }

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 🔴 VALIDATION
            if (txtFullName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtBalance.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            double balance;
            if (!double.TryParse(txtBalance.Text, out balance))
            {
                MessageBox.Show("Invalid balance!");
                return;
            }

            try
            {
                ConnectDB();
                conn.Open();

                // 🔴 CHECK IF USERNAME EXISTS
                OleDbCommand check = new OleDbCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username=?", conn);

                check.Parameters.AddWithValue("?", txtUsername.Text);

                int count = Convert.ToInt32(check.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Username already exists!");
                    conn.Close();
                    return;
                }

                // 🔵 INSERT USER
                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Users (Username, [Password], FullName, Balance) VALUES (?, ?, ?, ?)", conn);

                cmd.Parameters.AddWithValue("?", txtUsername.Text);
                cmd.Parameters.AddWithValue("?", txtPassword.Text);
                cmd.Parameters.AddWithValue("?", txtFullName.Text);
                cmd.Parameters.AddWithValue("?", balance);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");

                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }
    }
}