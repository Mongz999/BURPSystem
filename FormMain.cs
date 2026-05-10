using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BURPSystem
{
    public partial class FormMain : Form
    {
        // DATABASE CONNECTION
        OleDbConnection conn;

        // USER INFORMATION
        string currentUser;
        string fullName;
        double userBalance;

        // PAYMENT VARIABLES
        double subtotal = 0;
        double vat = 0;
        double total = 0;

        public FormMain(string username, string name, double balance)
        {
            InitializeComponent();

            currentUser = username;
            fullName = name;
            userBalance = balance;
        }

        // CONNECT TO DATABASE
        void ConnectDB()
        {
            string path = Application.StartupPath + @"\CanteenDB.accdb";

            conn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // LOAD DATA
            LoadProducts();
            LoadCategories();
            LoadProfile();
            LoadHistory();

            // PROFILE DISPLAY
            lblFullName.Text = fullName;
            lblUsername.Text = "@" + currentUser;
            lblBalance.Text = "₱ " + userBalance.ToString("0.00");

            // ROUND PROFILE PICTURE
            MakePictureRound();

            // CART TABLE
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("Product", "Product");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Qty", "Qty");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            dgvCart.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // DEFAULT VALUES
            txtQty.Minimum = 1;
            txtQty.Value = 1;

            lblSubtotal.Text = "₱ 0.00";
            lblvat.Text = "₱ 0.00";
            lblTotal.Text = "₱ 0.00";
            lblChange.Text = "₱ 0.00";

            // PRINT SETUP
            printPreviewReceipt.Document = printDocReceipt;

            // TABLE SETTINGS
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.RowHeadersVisible = false;

            dgvCart.AllowUserToAddRows = false;
        }

        // LOAD PRODUCTS
        private void LoadProducts()
        {
            ConnectDB();
            conn.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(
                "SELECT ProductName, Category, Price FROM Products",
                conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProducts.DataSource = dt;

            conn.Close();
        }

        // LOAD CATEGORIES
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");

            ConnectDB();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(
                "SELECT DISTINCT Category FROM Products",
                conn);

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbCategory.Items.Add(
                    dr["Category"].ToString());
            }

            conn.Close();

            cmbCategory.SelectedIndex = 0;
        }

        // LOAD PROFILE PHOTO
        private void LoadProfile()
        {
            try
            {
                ConnectDB();
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "SELECT ProfilePic FROM Users WHERE Username=?",
                    conn);

                cmd.Parameters.AddWithValue("?", currentUser);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string path = result.ToString();

                    if (System.IO.File.Exists(path))
                    {
                        picProfile.Image =
                            new Bitmap(path);
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LOAD TRANSACTION HISTORY
        private void LoadHistory()
        {
            try
            {
                ConnectDB();
                conn.Open();

                OleDbDataAdapter da =
                    new OleDbDataAdapter(
                    "SELECT OrderID, TotalAmount, DateOrdered FROM Orders WHERE Username=?",
                    conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "?",
                    currentUser);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHistory.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ROUND PROFILE PICTURE
        private void MakePictureRound()
        {
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(
                0,
                0,
                picProfile.Width,
                picProfile.Height);

            picProfile.Region = new Region(path);
        }

        // SEARCH PRODUCTS
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            (dgvProducts.DataSource as DataTable)
                .DefaultView.RowFilter =
                "ProductName LIKE '%" +
                txtSearch.Text +
                "%'";
        }

        // FILTER CATEGORY
        private void cmbCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbCategory.Text == "All")
            {
                LoadProducts();
                return;
            }

            ConnectDB();
            conn.Open();

            OleDbDataAdapter da =
                new OleDbDataAdapter(
                "SELECT ProductName, Category, Price FROM Products WHERE Category=?",
                conn);

            da.SelectCommand.Parameters.AddWithValue(
                "?",
                cmbCategory.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProducts.DataSource = dt;

            conn.Close();
        }

        // ADD TO CART
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            string name =
                dgvProducts.CurrentRow.Cells["ProductName"]
                .Value.ToString();

            double price = Convert.ToDouble(
                dgvProducts.CurrentRow.Cells["Price"]
                .Value);

            int qty = (int)txtQty.Value;

            double itemTotal = price * qty;

            dgvCart.Rows.Add(
                name,
                price,
                qty,
                itemTotal);

            subtotal += itemTotal;

            UpdateTotals();
        }

        // UPDATE TOTALS
        private void UpdateTotals()
        {
            vat = subtotal * 0.12;
            total = subtotal + vat;

            lblSubtotal.Text =
                "₱ " + subtotal.ToString("0.00");

            lblvat.Text =
                "₱ " + vat.ToString("0.00");

            lblTotal.Text =
                "₱ " + total.ToString("0.00");
        }

        // REMOVE ITEM
        private void btnRemove_Click(
            object sender,
            EventArgs e)
        {
            if (dgvCart.CurrentRow != null &&
                !dgvCart.CurrentRow.IsNewRow)
            {
                DialogResult result =
                    MessageBox.Show(
                    "Remove this item?",
                    "Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    double value = Convert.ToDouble(
                        dgvCart.CurrentRow.Cells[3]
                        .Value);

                    subtotal -= value;

                    dgvCart.Rows.Remove(
                        dgvCart.CurrentRow);

                    UpdateTotals();
                }
            }
            else
            {
                MessageBox.Show(
                    "Select an item first!");
            }
        }

        // CHECKOUT
        private void btnCheckout_Click(
            object sender,
            EventArgs e)
        {
            if (subtotal == 0)
            {
                MessageBox.Show("No items!");
                return;
            }

            double cash;

            // CHECK CASH INPUT
            if (!double.TryParse(
                txtCash.Text,
                out cash))
            {
                MessageBox.Show(
                    "Enter valid cash!");

                return;
            }

            // CHECK CASH
            if (cash < total)
            {
                MessageBox.Show(
                    "Insufficient cash!");

                return;
            }

            // CHECK BALANCE
            if (userBalance < total)
            {
                MessageBox.Show(
                    "Not enough balance!");

                return;
            }

            double change = cash - total;

            lblChange.Text =
                "₱ " + change.ToString("0.00");

            // UPDATE BALANCE
            userBalance -= total;

            lblBalance.Text =
                "₱ " + userBalance.ToString("0.00");

            try
            {
                ConnectDB();
                conn.Open();

                // SAVE ORDER
                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Orders (TotalAmount, DateOrdered, Username) VALUES (?, ?, ?)",
                    conn);

                cmd.Parameters.Add("?", OleDbType.Double).Value = total;
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = currentUser;

                cmd.ExecuteNonQuery();

                // UPDATE USER BALANCE
                OleDbCommand update = new OleDbCommand(
                    "UPDATE Users SET Balance=? WHERE Username=?",
                    conn);

                update.Parameters.Add("?", OleDbType.Double).Value = userBalance;
                update.Parameters.Add("?", OleDbType.VarChar).Value = currentUser;

                update.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Transaction Complete!");

                // REFRESH HISTORY
                LoadHistory();

                // DISPLAY RECEIPT
                txtReceipt.Clear();

                txtReceipt.AppendText("====== BURP RECEIPT ======\r\n");
                txtReceipt.AppendText("Date: " + DateTime.Now + "\r\n\r\n");

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        txtReceipt.AppendText(
                            row.Cells[0].Value.ToString() +
                            " x" +
                            row.Cells[2].Value.ToString() +
                            " = ₱" +
                            row.Cells[3].Value.ToString() +
                            "\r\n");
                    }
                }

                txtReceipt.AppendText("\r\nTOTAL: " + lblTotal.Text);
                txtReceipt.AppendText("\r\nCash: ₱" + cash.ToString("0.00"));
                txtReceipt.AppendText("\r\nChange: ₱" + change.ToString("0.00"));

                // CLEAR CART
                dgvCart.Rows.Clear();

                subtotal = 0;
                vat = 0;
                total = 0;

                UpdateTotals();

                txtCash.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // TOP UP BALANCE
        private void btnTopUp_Click(
            object sender,
            EventArgs e)
        {
            double amount;

            if (!double.TryParse(
                txtTopUp.Text,
                out amount))
            {
                MessageBox.Show(
                    "Enter valid amount!");

                return;
            }

            try
            {
                userBalance += amount;

                lblBalance.Text =
                    "₱ " + userBalance.ToString("0.00");

                ConnectDB();
                conn.Open();

                OleDbCommand cmd =
                    new OleDbCommand(
                    "UPDATE Users SET Balance=? WHERE Username=?",
                    conn);

                cmd.Parameters.AddWithValue(
                    "?",
                    userBalance);

                cmd.Parameters.AddWithValue(
                    "?",
                    currentUser);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(
                    "Top-up successful!");

                txtTopUp.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // UPLOAD PROFILE PHOTO
        private void btnUpload_Click(
            object sender,
            EventArgs e)
        {
            OpenFileDialog op =
                new OpenFileDialog();

            op.Filter =
                "Image Files|*.jpg;*.jpeg;*.png";

            if (op.ShowDialog() ==
                DialogResult.OK)
            {
                try
                {
                    string path = op.FileName;

                    picProfile.Image =
                        new Bitmap(path);

                    ConnectDB();
                    conn.Open();

                    OleDbCommand cmd =
                        new OleDbCommand(
                        "UPDATE Users SET ProfilePic=? WHERE Username=?",
                        conn);

                    cmd.Parameters.AddWithValue(
                        "?",
                        path);

                    cmd.Parameters.AddWithValue(
                        "?",
                        currentUser);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show(
                        "Profile updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // PRINT RECEIPT
        private void btnPrint_Click(
            object sender,
            EventArgs e)
        {
            printPreviewReceipt.ShowDialog();
        }

        private void printDocReceipt_PrintPage(
            object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
                txtReceipt.Text,
                new Font("Arial", 10),
                Brushes.Black,
                10,
                10);
        }

        // VIEW HISTORY
        private void btnHistory_Click(
            object sender,
            EventArgs e)
        {
            LoadHistory();

            MessageBox.Show("Transaction history refreshed!");
        }

        // LOGOUT
        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            FormLogin login =
                new FormLogin();

            login.Show();

            this.Close();
        }

        // CATEGORY BUTTONS
        private void btnAll_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "All";
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "Burger";
        }

        private void btnHotdog_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "Hotdog";
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "Sandwiches";
        }

        private void btnSides_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "Sides";
        }

        private void btnNoodles_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "Noodles";
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = "Drinks";
        }
    }
}