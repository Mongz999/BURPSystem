using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BURPSystem
{
    public partial class FormRegister : Form
    {
        // DATABASE CONNECTION
        OleDbConnection conn;

        public FormRegister()
        {
            InitializeComponent();
        }

        // CONNECT TO DATABASE
        void ConnectDB()
        {
            string path = Application.StartupPath + @"\CanteenDB.accdb";

            conn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // CHECK IF FIELDS ARE EMPTY
            if (txtFullName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtBalance.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            // CHECK IF BALANCE IS VALID
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

                // CHECK IF USERNAME ALREADY EXISTS
                OleDbCommand check = new OleDbCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username=?",
                    conn);

                check.Parameters.AddWithValue("?", txtUsername.Text);

                int count = Convert.ToInt32(check.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Username already exists!");
                    conn.Close();
                    return;
                }

                // SAVE USER TO DATABASE
                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Users (Username, [Password], FullName, Balance) VALUES (?, ?, ?, ?)",
                    conn);

                cmd.Parameters.AddWithValue("?", txtUsername.Text);
                cmd.Parameters.AddWithValue("?", txtPassword.Text);
                cmd.Parameters.AddWithValue("?", txtFullName.Text);
                cmd.Parameters.AddWithValue("?", balance);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Registration Successful!");

                this.Close();
            }
            catch (Exception ex)
            {
                // SHOW ERROR MESSAGE
                MessageBox.Show(ex.Message);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // SHOW OR HIDE PASSWORD
            txtPassword.UseSystemPasswordChar =
                !chkShowPass.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // CLOSE REGISTER FORM
            this.Close();
        }
    }
}