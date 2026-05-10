using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BURPSystem
{
    public partial class FormLogin : Form
    {
        // DATABASE CONNECTION
        OleDbConnection conn;

        public FormLogin()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // CHECK EMPTY FIELDS
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter username and password!");
                return;
            }

            try
            {
                ConnectDB();
                conn.Open();

                // CHECK USER ACCOUNT
                OleDbCommand cmd = new OleDbCommand(
                    "SELECT * FROM Users WHERE Username=? AND [Password]=?",
                    conn);

                cmd.Parameters.AddWithValue("?", txtUsername.Text);
                cmd.Parameters.AddWithValue("?", txtPassword.Text);

                OleDbDataReader dr = cmd.ExecuteReader();

                // LOGIN SUCCESS
                if (dr.Read())
                {
                    FormMain main = new FormMain(
                        dr["Username"].ToString(),
                        dr["FullName"].ToString(),
                        Convert.ToDouble(dr["Balance"])
                    );

                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");

                    txtPassword.Clear();
                    txtPassword.Focus();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // SHOW ERROR
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // OPEN REGISTER FORM
            FormRegister reg = new FormRegister();
            reg.ShowDialog();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // SHOW OR HIDE PASSWORD
            txtPassword.UseSystemPasswordChar =
                !chkShowPass.Checked;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            // CLEAR PLACEHOLDER
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }
    }
}