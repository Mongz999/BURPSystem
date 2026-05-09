namespace BURPSystem
{
    partial class FormRegister
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
            this.gpright = new System.Windows.Forms.GroupBox();
            this.gprreg = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblreg = new System.Windows.Forms.Label();
            this.gpleft = new System.Windows.Forms.GroupBox();
            this.lblqoute = new System.Windows.Forms.Label();
            this.lblburp = new System.Windows.Forms.Label();
            this.gpright.SuspendLayout();
            this.gprreg.SuspendLayout();
            this.gpleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpright
            // 
            this.gpright.BackColor = System.Drawing.SystemColors.Window;
            this.gpright.Controls.Add(this.gprreg);
            this.gpright.Location = new System.Drawing.Point(443, -6);
            this.gpright.Name = "gpright";
            this.gpright.Size = new System.Drawing.Size(472, 732);
            this.gpright.TabIndex = 3;
            this.gpright.TabStop = false;
            // 
            // gprreg
            // 
            this.gprreg.Controls.Add(this.txtBalance);
            this.gprreg.Controls.Add(this.txtFullName);
            this.gprreg.Controls.Add(this.btnBack);
            this.gprreg.Controls.Add(this.chkShowPass);
            this.gprreg.Controls.Add(this.btnRegister);
            this.gprreg.Controls.Add(this.txtPassword);
            this.gprreg.Controls.Add(this.txtUsername);
            this.gprreg.Controls.Add(this.lblreg);
            this.gprreg.Location = new System.Drawing.Point(49, 129);
            this.gprreg.Name = "gprreg";
            this.gprreg.Size = new System.Drawing.Size(397, 481);
            this.gprreg.TabIndex = 0;
            this.gprreg.TabStop = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBalance.Location = new System.Drawing.Point(27, 286);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(339, 30);
            this.txtBalance.TabIndex = 8;
            this.txtBalance.Text = "Balance";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFullName.Location = new System.Drawing.Point(27, 124);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(339, 30);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.Text = "Full Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(27, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(339, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkShowPass.Location = new System.Drawing.Point(27, 250);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(118, 21);
            this.chkShowPass.TabIndex = 1;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Indigo;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegister.Location = new System.Drawing.Point(27, 352);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(339, 40);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(27, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(339, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(27, 170);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblreg.ForeColor = System.Drawing.Color.Indigo;
            this.lblreg.Location = new System.Drawing.Point(150, 45);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(123, 37);
            this.lblreg.TabIndex = 0;
            this.lblreg.Text = "Register";
            // 
            // gpleft
            // 
            this.gpleft.BackColor = System.Drawing.Color.Indigo;
            this.gpleft.Controls.Add(this.lblqoute);
            this.gpleft.Controls.Add(this.lblburp);
            this.gpleft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpleft.Location = new System.Drawing.Point(-1, -6);
            this.gpleft.Name = "gpleft";
            this.gpleft.Size = new System.Drawing.Size(445, 732);
            this.gpleft.TabIndex = 4;
            this.gpleft.TabStop = false;
            // 
            // lblqoute
            // 
            this.lblqoute.AutoSize = true;
            this.lblqoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic);
            this.lblqoute.ForeColor = System.Drawing.SystemColors.Window;
            this.lblqoute.Location = new System.Drawing.Point(112, 410);
            this.lblqoute.Name = "lblqoute";
            this.lblqoute.Size = new System.Drawing.Size(226, 28);
            this.lblqoute.TabIndex = 2;
            this.lblqoute.Text = "Good Food, Good Mood!";
            // 
            // lblburp
            // 
            this.lblburp.AutoSize = true;
            this.lblburp.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblburp.ForeColor = System.Drawing.Color.Yellow;
            this.lblburp.Location = new System.Drawing.Point(58, 241);
            this.lblburp.Name = "lblburp";
            this.lblburp.Size = new System.Drawing.Size(339, 128);
            this.lblburp.TabIndex = 1;
            this.lblburp.Text = "BURP!";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 721);
            this.Controls.Add(this.gpleft);
            this.Controls.Add(this.gpright);
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.gpright.ResumeLayout(false);
            this.gprreg.ResumeLayout(false);
            this.gprreg.PerformLayout();
            this.gpleft.ResumeLayout(false);
            this.gpleft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpright;
        private System.Windows.Forms.GroupBox gprreg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.GroupBox gpleft;
        private System.Windows.Forms.Label lblburp;
        private System.Windows.Forms.Label lblqoute;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtFullName;
    }
}