using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURPSystem
{
    public partial class FormLogin : Form
    {
        //DB CONNECTION
        OleDbConnection conn = new OleDbConnection(
        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CanteenDB.accdb");

        public FormLogin()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister reg = new FormRegister();
            reg.ShowDialog();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter username and password!");
                return;
            }

            try
            {
                conn.Open();

                // CHECK USERS FIRST
                OleDbCommand cmd = new OleDbCommand(
                    "SELECT * FROM Users WHERE Username=? AND [Password]=?", conn);

                cmd.Parameters.AddWithValue("?", txtUsername.Text);
                cmd.Parameters.AddWithValue("?", txtPassword.Text);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // USER LOGIN
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
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
