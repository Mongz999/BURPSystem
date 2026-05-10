namespace BURPSystem
{
    partial class FormLogin
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
            this.lblburp = new System.Windows.Forms.Label();
            this.lblqoute = new System.Windows.Forms.Label();
            this.gpright = new System.Windows.Forms.GroupBox();
            this.gplogin = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.gpright.SuspendLayout();
            this.gplogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblburp
            // 
            this.lblburp.AutoSize = true;
            this.lblburp.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblburp.ForeColor = System.Drawing.Color.Yellow;
            this.lblburp.Location = new System.Drawing.Point(58, 241);
            this.lblburp.Name = "lblburp";
            this.lblburp.Size = new System.Drawing.Size(339, 128);
            this.lblburp.TabIndex = 0;
            this.lblburp.Text = "BURP!";
            // 
            // lblqoute
            // 
            this.lblqoute.AutoSize = true;
            this.lblqoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic);
            this.lblqoute.ForeColor = System.Drawing.SystemColors.Window;
            this.lblqoute.Location = new System.Drawing.Point(112, 410);
            this.lblqoute.Name = "lblqoute";
            this.lblqoute.Size = new System.Drawing.Size(226, 28);
            this.lblqoute.TabIndex = 1;
            this.lblqoute.Text = "Good Food, Good Mood!";
            // 
            // gpright
            // 
            this.gpright.BackColor = System.Drawing.SystemColors.Window;
            this.gpright.Controls.Add(this.gplogin);
            this.gpright.Location = new System.Drawing.Point(443, -6);
            this.gpright.Name = "gpright";
            this.gpright.Size = new System.Drawing.Size(472, 726);
            this.gpright.TabIndex = 2;
            this.gpright.TabStop = false;
            // 
            // gplogin
            // 
            this.gplogin.Controls.Add(this.btnRegister);
            this.gplogin.Controls.Add(this.chkShowPass);
            this.gplogin.Controls.Add(this.btnLogin);
            this.gplogin.Controls.Add(this.txtPassword);
            this.gplogin.Controls.Add(this.txtUsername);
            this.gplogin.Controls.Add(this.lblwarning);
            this.gplogin.Controls.Add(this.lbllogin);
            this.gplogin.Location = new System.Drawing.Point(49, 129);
            this.gplogin.Name = "gplogin";
            this.gplogin.Size = new System.Drawing.Size(397, 481);
            this.gplogin.TabIndex = 0;
            this.gplogin.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DimGray;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegister.Location = new System.Drawing.Point(27, 376);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(339, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkShowPass.Location = new System.Drawing.Point(27, 292);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(118, 21);
            this.chkShowPass.TabIndex = 1;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Indigo;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogin.Location = new System.Drawing.Point(27, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(339, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(27, 256);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(339, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(27, 196);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.Location = new System.Drawing.Point(74, 130);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(245, 17);
            this.lblwarning.TabIndex = 1;
            this.lblwarning.Text = "Please enter your credentials to continue";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbllogin.ForeColor = System.Drawing.Color.Indigo;
            this.lbllogin.Location = new System.Drawing.Point(150, 75);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(89, 37);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(914, 720);
            this.Controls.Add(this.gpright);
            this.Controls.Add(this.lblqoute);
            this.Controls.Add(this.lblburp);
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.gpright.ResumeLayout(false);
            this.gplogin.ResumeLayout(false);
            this.gplogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblburp;
        private System.Windows.Forms.Label lblqoute;
        private System.Windows.Forms.GroupBox gpright;
        private System.Windows.Forms.GroupBox gplogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkShowPass;
    }
}