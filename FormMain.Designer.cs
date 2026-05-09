namespace BURPSystem
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBurp = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblmenu = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelCart = new System.Windows.Forms.Panel();
            this.lblcart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panelrcpt = new System.Windows.Forms.Panel();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.lblrcpt = new System.Windows.Forms.Label();
            this.panelchckout = new System.Windows.Forms.Panel();
            this.txtTopUp = new System.Windows.Forms.TextBox();
            this.lbltopup = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_vat = new System.Windows.Forms.Label();
            this.lblsbtotal = new System.Windows.Forms.Label();
            this.panelqcatbtns = new System.Windows.Forms.Panel();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnNoodles = new System.Windows.Forms.Button();
            this.btnSlides = new System.Windows.Forms.Button();
            this.btnSandwiches = new System.Windows.Forms.Button();
            this.btnHotdog = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblqcatbtn = new System.Windows.Forms.Label();
            this.panelqty = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.lblqty = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.printDocReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewReceipt = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.paneltranshist = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panelrcpt.SuspendLayout();
            this.panelchckout.SuspendLayout();
            this.panelqcatbtns.SuspendLayout();
            this.panelqty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.paneltranshist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBurp
            // 
            this.lblBurp.AutoSize = true;
            this.lblBurp.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblBurp.ForeColor = System.Drawing.Color.Yellow;
            this.lblBurp.Location = new System.Drawing.Point(66, 0);
            this.lblBurp.Name = "lblBurp";
            this.lblBurp.Size = new System.Drawing.Size(190, 72);
            this.lblBurp.TabIndex = 1;
            this.lblBurp.Text = "BURP!";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Indigo;
            this.paneltop.Controls.Add(this.btnLogout);
            this.paneltop.Controls.Add(this.lblBalance);
            this.paneltop.Controls.Add(this.lblUsername);
            this.paneltop.Controls.Add(this.lblFullName);
            this.paneltop.Controls.Add(this.btnUpload);
            this.paneltop.Controls.Add(this.picProfile);
            this.paneltop.Controls.Add(this.lblBurp);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1371, 80);
            this.paneltop.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Yellow;
            this.lblBalance.Location = new System.Drawing.Point(861, 51);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 21);
            this.lblBalance.TabIndex = 22;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsername.Location = new System.Drawing.Point(861, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 21);
            this.lblUsername.TabIndex = 21;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFullName.Location = new System.Drawing.Point(861, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 21);
            this.lblFullName.TabIndex = 5;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(1227, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(118, 29);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload Photo";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.SystemColors.Window;
            this.picProfile.Location = new System.Drawing.Point(755, 12);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(100, 50);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 3;
            this.picProfile.TabStop = false;
            // 
            // btnTopUp
            // 
            this.btnTopUp.BackColor = System.Drawing.Color.Green;
            this.btnTopUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopUp.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTopUp.Location = new System.Drawing.Point(331, 107);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(179, 29);
            this.btnTopUp.TabIndex = 20;
            this.btnTopUp.Text = "TOP UP";
            this.btnTopUp.UseVisualStyleBackColor = false;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsearch.Location = new System.Drawing.Point(12, 92);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(60, 21);
            this.lblsearch.TabIndex = 6;
            this.lblsearch.Text = "Search:";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblcategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcategory.Location = new System.Drawing.Point(307, 92);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(76, 21);
            this.lblcategory.TabIndex = 7;
            this.lblcategory.Text = "Category:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(78, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 29);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "Search Product...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(389, 89);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 29);
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.Click += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Indigo;
            this.panelMenu.Controls.Add(this.lblmenu);
            this.panelMenu.Controls.Add(this.dgvProducts);
            this.panelMenu.Location = new System.Drawing.Point(12, 124);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(590, 287);
            this.panelMenu.TabIndex = 10;
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.BackColor = System.Drawing.Color.Indigo;
            this.lblmenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.ForeColor = System.Drawing.SystemColors.Window;
            this.lblmenu.Location = new System.Drawing.Point(3, 5);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(72, 28);
            this.lblmenu.TabIndex = 16;
            this.lblmenu.Text = "MENU";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(0, 36);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(590, 251);
            this.dgvProducts.TabIndex = 15;
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.Indigo;
            this.panelCart.Controls.Add(this.lblcart);
            this.panelCart.Controls.Add(this.dgvCart);
            this.panelCart.Location = new System.Drawing.Point(768, 124);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(590, 287);
            this.panelCart.TabIndex = 11;
            // 
            // lblcart
            // 
            this.lblcart.AutoSize = true;
            this.lblcart.BackColor = System.Drawing.Color.Indigo;
            this.lblcart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcart.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcart.Location = new System.Drawing.Point(3, 5);
            this.lblcart.Name = "lblcart";
            this.lblcart.Size = new System.Drawing.Size(63, 28);
            this.lblcart.TabIndex = 17;
            this.lblcart.Text = "CART";
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(0, 36);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(590, 251);
            this.dgvCart.TabIndex = 16;
            // 
            // panelrcpt
            // 
            this.panelrcpt.BackColor = System.Drawing.Color.Indigo;
            this.panelrcpt.Controls.Add(this.txtReceipt);
            this.panelrcpt.Controls.Add(this.lblrcpt);
            this.panelrcpt.Location = new System.Drawing.Point(12, 462);
            this.panelrcpt.Name = "panelrcpt";
            this.panelrcpt.Size = new System.Drawing.Size(590, 287);
            this.panelrcpt.TabIndex = 12;
            // 
            // txtReceipt
            // 
            this.txtReceipt.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtReceipt.Location = new System.Drawing.Point(0, 31);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.Size = new System.Drawing.Size(590, 300);
            this.txtReceipt.TabIndex = 17;
            // 
            // lblrcpt
            // 
            this.lblrcpt.AutoSize = true;
            this.lblrcpt.BackColor = System.Drawing.Color.Indigo;
            this.lblrcpt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrcpt.ForeColor = System.Drawing.SystemColors.Window;
            this.lblrcpt.Location = new System.Drawing.Point(3, 0);
            this.lblrcpt.Name = "lblrcpt";
            this.lblrcpt.Size = new System.Drawing.Size(89, 28);
            this.lblrcpt.TabIndex = 17;
            this.lblrcpt.Text = "RECEIPT";
            // 
            // panelchckout
            // 
            this.panelchckout.BackColor = System.Drawing.SystemColors.Window;
            this.panelchckout.Controls.Add(this.txtTopUp);
            this.panelchckout.Controls.Add(this.lbltopup);
            this.panelchckout.Controls.Add(this.btnTopUp);
            this.panelchckout.Controls.Add(this.lblChange);
            this.panelchckout.Controls.Add(this.lblTotal);
            this.panelchckout.Controls.Add(this.lblvat);
            this.panelchckout.Controls.Add(this.lblSubtotal);
            this.panelchckout.Controls.Add(this.lbl_cash);
            this.panelchckout.Controls.Add(this.btnCheckout);
            this.panelchckout.Controls.Add(this.txtCash);
            this.panelchckout.Controls.Add(this.lbl_change);
            this.panelchckout.Controls.Add(this.lbl_total);
            this.panelchckout.Controls.Add(this.lbl_vat);
            this.panelchckout.Controls.Add(this.lblsbtotal);
            this.panelchckout.Location = new System.Drawing.Point(769, 493);
            this.panelchckout.Name = "panelchckout";
            this.panelchckout.Size = new System.Drawing.Size(590, 237);
            this.panelchckout.TabIndex = 13;
            // 
            // txtTopUp
            // 
            this.txtTopUp.Location = new System.Drawing.Point(181, 114);
            this.txtTopUp.Name = "txtTopUp";
            this.txtTopUp.Size = new System.Drawing.Size(100, 20);
            this.txtTopUp.TabIndex = 24;
            // 
            // lbltopup
            // 
            this.lbltopup.AutoSize = true;
            this.lbltopup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbltopup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltopup.Location = new System.Drawing.Point(3, 111);
            this.lbltopup.Name = "lbltopup";
            this.lbltopup.Size = new System.Drawing.Size(61, 21);
            this.lbltopup.TabIndex = 23;
            this.lbltopup.Text = "Top Up:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(220, 149);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 21);
            this.lblChange.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(220, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 21);
            this.lblTotal.TabIndex = 21;
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.Location = new System.Drawing.Point(220, 30);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(0, 21);
            this.lblvat.TabIndex = 20;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(220, 9);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 21);
            this.lblSubtotal.TabIndex = 19;
            // 
            // lbl_cash
            // 
            this.lbl_cash.AutoSize = true;
            this.lbl_cash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_cash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cash.Location = new System.Drawing.Point(3, 78);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(47, 21);
            this.lbl_cash.TabIndex = 18;
            this.lbl_cash.Text = "Cash:";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCheckout.Location = new System.Drawing.Point(215, 182);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(179, 43);
            this.btnCheckout.TabIndex = 17;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(181, 81);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(100, 20);
            this.txtCash.TabIndex = 11;
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_change.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_change.Location = new System.Drawing.Point(3, 149);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(66, 21);
            this.lbl_change.TabIndex = 10;
            this.lbl_change.Text = "Change:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(4, 53);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(60, 21);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "TOTAL:";
            // 
            // lbl_vat
            // 
            this.lbl_vat.AutoSize = true;
            this.lbl_vat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_vat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vat.Location = new System.Drawing.Point(3, 30);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(84, 21);
            this.lbl_vat.TabIndex = 8;
            this.lbl_vat.Text = "VAT (12%):";
            // 
            // lblsbtotal
            // 
            this.lblsbtotal.AutoSize = true;
            this.lblsbtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblsbtotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsbtotal.Location = new System.Drawing.Point(3, 9);
            this.lblsbtotal.Name = "lblsbtotal";
            this.lblsbtotal.Size = new System.Drawing.Size(71, 21);
            this.lblsbtotal.TabIndex = 7;
            this.lblsbtotal.Text = "Subtotal:";
            // 
            // panelqcatbtns
            // 
            this.panelqcatbtns.BackColor = System.Drawing.Color.Indigo;
            this.panelqcatbtns.Controls.Add(this.btnDrinks);
            this.panelqcatbtns.Controls.Add(this.btnNoodles);
            this.panelqcatbtns.Controls.Add(this.btnSlides);
            this.panelqcatbtns.Controls.Add(this.btnSandwiches);
            this.panelqcatbtns.Controls.Add(this.btnHotdog);
            this.panelqcatbtns.Controls.Add(this.btnBurger);
            this.panelqcatbtns.Controls.Add(this.btnAll);
            this.panelqcatbtns.Controls.Add(this.lblqcatbtn);
            this.panelqcatbtns.Location = new System.Drawing.Point(768, 765);
            this.panelqcatbtns.Name = "panelqcatbtns";
            this.panelqcatbtns.Size = new System.Drawing.Size(590, 138);
            this.panelqcatbtns.TabIndex = 14;
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Olive;
            this.btnDrinks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDrinks.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDrinks.Location = new System.Drawing.Point(371, 85);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(139, 39);
            this.btnDrinks.TabIndex = 24;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnNoodles
            // 
            this.btnNoodles.BackColor = System.Drawing.Color.Red;
            this.btnNoodles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNoodles.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNoodles.Location = new System.Drawing.Point(226, 85);
            this.btnNoodles.Name = "btnNoodles";
            this.btnNoodles.Size = new System.Drawing.Size(139, 39);
            this.btnNoodles.TabIndex = 23;
            this.btnNoodles.Text = "Noodles";
            this.btnNoodles.UseVisualStyleBackColor = false;
            this.btnNoodles.Click += new System.EventHandler(this.btnNoodles_Click);
            // 
            // btnSlides
            // 
            this.btnSlides.BackColor = System.Drawing.Color.Crimson;
            this.btnSlides.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSlides.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSlides.Location = new System.Drawing.Point(81, 85);
            this.btnSlides.Name = "btnSlides";
            this.btnSlides.Size = new System.Drawing.Size(139, 39);
            this.btnSlides.TabIndex = 22;
            this.btnSlides.Text = "Sides";
            this.btnSlides.UseVisualStyleBackColor = false;
            this.btnSlides.Click += new System.EventHandler(this.btnSides_Click);
            // 
            // btnSandwiches
            // 
            this.btnSandwiches.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSandwiches.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSandwiches.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSandwiches.Location = new System.Drawing.Point(443, 40);
            this.btnSandwiches.Name = "btnSandwiches";
            this.btnSandwiches.Size = new System.Drawing.Size(139, 39);
            this.btnSandwiches.TabIndex = 21;
            this.btnSandwiches.Text = "Sandwiches";
            this.btnSandwiches.UseVisualStyleBackColor = false;
            this.btnSandwiches.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // btnHotdog
            // 
            this.btnHotdog.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHotdog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHotdog.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHotdog.Location = new System.Drawing.Point(298, 40);
            this.btnHotdog.Name = "btnHotdog";
            this.btnHotdog.Size = new System.Drawing.Size(139, 39);
            this.btnHotdog.TabIndex = 20;
            this.btnHotdog.Text = "Hotdog";
            this.btnHotdog.UseVisualStyleBackColor = false;
            this.btnHotdog.Click += new System.EventHandler(this.btnHotdog_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBurger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBurger.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBurger.Location = new System.Drawing.Point(153, 40);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(139, 39);
            this.btnBurger.TabIndex = 19;
            this.btnBurger.Text = "Burger";
            this.btnBurger.UseVisualStyleBackColor = false;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAll.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAll.Location = new System.Drawing.Point(8, 40);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(139, 39);
            this.btnAll.TabIndex = 18;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblqcatbtn
            // 
            this.lblqcatbtn.AutoSize = true;
            this.lblqcatbtn.BackColor = System.Drawing.Color.Indigo;
            this.lblqcatbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqcatbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.lblqcatbtn.Location = new System.Drawing.Point(3, 0);
            this.lblqcatbtn.Name = "lblqcatbtn";
            this.lblqcatbtn.Size = new System.Drawing.Size(278, 28);
            this.lblqcatbtn.TabIndex = 17;
            this.lblqcatbtn.Text = "QUICK CATEGORY BUTTONS";
            // 
            // panelqty
            // 
            this.panelqty.BackColor = System.Drawing.SystemColors.Window;
            this.panelqty.Controls.Add(this.txtQty);
            this.panelqty.Controls.Add(this.lblqty);
            this.panelqty.Location = new System.Drawing.Point(12, 418);
            this.panelqty.Name = "panelqty";
            this.panelqty.Size = new System.Drawing.Size(221, 38);
            this.panelqty.TabIndex = 15;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(83, 6);
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(120, 29);
            this.txtQty.TabIndex = 8;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblqty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblqty.Location = new System.Drawing.Point(4, 8);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(73, 21);
            this.lblqty.TabIndex = 7;
            this.lblqty.Text = "Quantity:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(311, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(229, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD TO CART";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Location = new System.Drawing.Point(849, 426);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(179, 41);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "REMOVE ITEM";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // printDocReceipt
            // 
            this.printDocReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocReceipt_PrintPage);
            // 
            // printPreviewReceipt
            // 
            this.printPreviewReceipt.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrint.Location = new System.Drawing.Point(1099, 426);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 41);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "PRINT RECEIPT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // paneltranshist
            // 
            this.paneltranshist.BackColor = System.Drawing.Color.Indigo;
            this.paneltranshist.Controls.Add(this.btnHistory);
            this.paneltranshist.Controls.Add(this.dgvHistory);
            this.paneltranshist.Location = new System.Drawing.Point(12, 762);
            this.paneltranshist.Name = "paneltranshist";
            this.paneltranshist.Size = new System.Drawing.Size(590, 287);
            this.paneltranshist.TabIndex = 20;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SlateGray;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHistory.Location = new System.Drawing.Point(4, 3);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(187, 31);
            this.btnHistory.TabIndex = 21;
            this.btnHistory.Text = "TRANSACTION HISTORY";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(0, 36);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(590, 251);
            this.dgvHistory.TabIndex = 21;
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.Location = new System.Drawing.Point(1227, 46);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 29);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1371, 1061);
            this.Controls.Add(this.paneltranshist);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelqty);
            this.Controls.Add(this.panelqcatbtns);
            this.Controls.Add(this.panelchckout);
            this.Controls.Add(this.panelrcpt);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.paneltop);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BURP";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panelrcpt.ResumeLayout(false);
            this.panelrcpt.PerformLayout();
            this.panelchckout.ResumeLayout(false);
            this.panelchckout.PerformLayout();
            this.panelqcatbtns.ResumeLayout(false);
            this.panelqcatbtns.PerformLayout();
            this.panelqty.ResumeLayout(false);
            this.panelqty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.paneltranshist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBurp;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Label lblcart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panelrcpt;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Label lblrcpt;
        private System.Windows.Forms.Panel panelchckout;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_vat;
        private System.Windows.Forms.Label lblsbtotal;
        private System.Windows.Forms.Panel panelqcatbtns;
        private System.Windows.Forms.Label lblqcatbtn;
        private System.Windows.Forms.Panel panelqty;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnHotdog;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnNoodles;
        private System.Windows.Forms.Button btnSlides;
        private System.Windows.Forms.Button btnSandwiches;
        private System.Windows.Forms.Button btnRemove;
        private System.Drawing.Printing.PrintDocument printDocReceipt;
        private System.Windows.Forms.PrintDialog printPreviewReceipt;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.TextBox txtTopUp;
        private System.Windows.Forms.Label lbltopup;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel paneltranshist;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLogout;
    }
}

