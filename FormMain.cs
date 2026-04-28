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
        OleDbConnection conn;

        // ✅ USER VARIABLES (FIXED)
        string currentUser;
        string fullName;
        double userBalance;

        void ConnectDB()
        {
            string path = Application.StartupPath + @"\CanteenDB.accdb";
            conn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
        }

        double subtotal = 0, vat = 0, total = 0;

        // ✅ UPDATED CONSTRUCTOR
        public FormMain(string username, string name, double balance)
        {
            InitializeComponent();

            currentUser = username;
            fullName = name;
            userBalance = balance;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            LoadProfile();
            MakePictureRound();

            // ✅ PROFILE DISPLAY
            lblFullName.Text = fullName;
            lblUsername.Text = "@" + currentUser;
            lblBalance.Text = "₱ " + userBalance.ToString("0.00");

            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("Product", "Product");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Qty", "Qty");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtQty.Minimum = 1;
            txtQty.Value = 1;

            lblSubtotal.Text = "₱ 0.00";
            lblvat.Text = "₱ 0.00";
            lblTotal.Text = "₱ 0.00";
            lblChange.Text = "₱ 0.00";

            printPreviewReceipt.Document = printDocReceipt;

            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.RowHeadersVisible = false;
        }

        private void LoadHistory()
        {
            try
            {
                ConnectDB();
                conn.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(
                    "SELECT OrderID, TotalAmount, DateOrdered FROM Orders WHERE Username=? ORDER BY DateOrdered DESC",
                    conn);

                da.SelectCommand.Parameters.AddWithValue("?", currentUser);

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

        private void MakePictureRound()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picProfile.Width, picProfile.Height);
            picProfile.Region = new Region(path);
        }

        private void LoadProducts()
        {
            ConnectDB();
            conn.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(
                "SELECT ProductName, Category, Price FROM Products", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProducts.DataSource = dt;
            conn.Close();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");

            ConnectDB();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(
                "SELECT DISTINCT Category FROM Products", conn);

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbCategory.Items.Add(dr["Category"].ToString());
            }

            conn.Close();
            cmbCategory.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvProducts.DataSource as DataTable).DefaultView.RowFilter =
                "ProductName LIKE '%" + txtSearch.Text + "%'";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "All")
            {
                LoadProducts();
                return;
            }

            ConnectDB();
            conn.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(
                "SELECT ProductName, Category, Price FROM Products WHERE Category=?", conn);

            da.SelectCommand.Parameters.AddWithValue("?", cmbCategory.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProducts.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            string name = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            double price = Convert.ToDouble(dgvProducts.CurrentRow.Cells["Price"].Value);
            int qty = (int)txtQty.Value;

            double itemTotal = price * qty;

            dgvCart.Rows.Add(name, price, qty, itemTotal);

            subtotal += itemTotal;
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            vat = subtotal * 0.12;
            total = subtotal + vat;

            lblSubtotal.Text = "₱ " + subtotal.ToString("0.00");
            lblvat.Text = "₱ " + vat.ToString("0.00");
            lblTotal.Text = "₱ " + total.ToString("0.00");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null)
            {
                double value = Convert.ToDouble(dgvCart.CurrentRow.Cells[3].Value);
                subtotal -= value;

                dgvCart.Rows.Remove(dgvCart.CurrentRow);
                UpdateTotals();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (subtotal == 0)
            {
                MessageBox.Show("No items!");
                return;
            }

            if (userBalance < total)
            {
                MessageBox.Show("Not enough balance!");
                return;
            }

            userBalance -= total;
            lblBalance.Text = "₱ " + userBalance.ToString("0.00");

            ConnectDB();
            conn.Open();

            // SAVE ORDER
            OleDbCommand cmd = new OleDbCommand(
                  "INSERT INTO Orders (TotalAmount, DateOrdered, Username) VALUES (?, ?, ?)", conn);

            cmd.Parameters.Add("?", OleDbType.Double).Value = total;
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
            cmd.Parameters.Add("?", OleDbType.VarChar).Value = currentUser;

            cmd.ExecuteNonQuery();

            // UPDATE BALANCE
            OleDbCommand update = new OleDbCommand(
                "UPDATE Users SET Balance=? WHERE Username=?", conn);

            update.Parameters.AddWithValue("?", userBalance);
            update.Parameters.AddWithValue("?", currentUser);
            update.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Transaction Complete!");

            txtReceipt.Clear();

            txtReceipt.AppendText("====== BURP RECEIPT ======\r\n");
            txtReceipt.AppendText("Date: " + DateTime.Now.ToString() + "\r\n\r\n");

            // ITEMS
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    txtReceipt.AppendText(
                        row.Cells[0].Value.ToString() + " x" +
                        row.Cells[2].Value.ToString() +
                        " = ₱" + row.Cells[3].Value.ToString() + "\r\n"
                    );
                }
            }

            // TOTALS
            txtReceipt.AppendText("\r\n--------------------------\r\n");
            txtReceipt.AppendText("Subtotal: " + lblSubtotal.Text + "\r\n");
            txtReceipt.AppendText("VAT (12%): " + lblvat.Text + "\r\n");
            txtReceipt.AppendText("TOTAL: " + lblTotal.Text + "\r\n\r\n");

            txtReceipt.AppendText("Remaining Balance: ₱ " + userBalance.ToString("0.00") + "\r\n");
            txtReceipt.AppendText("\r\nThank you!\r\n");
        }

        private void btnTopUp_Click(object sender, EventArgs e)
{
    double amount;

    // VALIDATION
    if (!double.TryParse(txtTopUp.Text, out amount) || amount <= 0)
    {
        MessageBox.Show("Enter a valid amount!");
        txtTopUp.Focus();
        return;
    }

    try
    {
        // ADD TO BALANCE
        userBalance += amount;

        // UPDATE LABEL
        lblBalance.Text = "₱ " + userBalance.ToString("0.00");

        // SAVE TO DATABASE
        ConnectDB();
        conn.Open();

        OleDbCommand cmd = new OleDbCommand(
            "UPDATE Users SET Balance=? WHERE Username=?", conn);

        cmd.Parameters.AddWithValue("?", userBalance);
        cmd.Parameters.AddWithValue("?", currentUser);

        cmd.ExecuteNonQuery();
        conn.Close();

        MessageBox.Show("Top-up successful!");

        // CLEAR INPUT
        txtTopUp.Clear();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

        private void LoadProfile()
        {
            ConnectDB();
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(
                "SELECT ProfilePic FROM Users WHERE Username=?", conn);

            cmd.Parameters.AddWithValue("?", currentUser);

            object result = cmd.ExecuteScalar();

            if (result != null && result.ToString() != "")
            {
                picProfile.Image = Image.FromFile(result.ToString());
            }

            conn.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.png";

            if (op.ShowDialog() == DialogResult.OK)
            {
                string path = op.FileName;
                picProfile.Image = Image.FromFile(path);

                ConnectDB();
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "UPDATE Users SET ProfilePic=? WHERE Username=?", conn);

                cmd.Parameters.AddWithValue("?", path);
                cmd.Parameters.AddWithValue("?", currentUser);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void SetCategory(string category)
        {
            cmbCategory.SelectedItem = category;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SetCategory("All");
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            SetCategory("Burger");
        }

        private void btnHotdog_Click(object sender, EventArgs e)
        {
            SetCategory("Hotdog");
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            SetCategory("Sandwiches");
        }

        private void btnSides_Click(object sender, EventArgs e)
        {
            SetCategory("Sides");
        }

        private void btnNoodles_Click(object sender, EventArgs e)
        {
            SetCategory("Noodles");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            SetCategory("Drinks");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewReceipt.ShowDialog();
        }

        private void printDocReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string receipt = "====== BURP RECEIPT ======\n\n";

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    receipt += row.Cells[0].Value.ToString() + "  x" +
                               row.Cells[2].Value.ToString() + "  = ₱" +
                               row.Cells[3].Value.ToString() + "\n";
                }
            }

            receipt += "\n---------------------------\n";
            receipt += "Subtotal: " + lblSubtotal.Text + "\n";
            receipt += "VAT: " + lblvat.Text + "\n";
            receipt += "TOTAL: " + lblTotal.Text + "\n\n";
            receipt += "Thank you!\n";

            e.Graphics.DrawString(receipt,
                new Font("Arial", 10),
                Brushes.Black,
                10, 10);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}