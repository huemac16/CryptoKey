namespace CryptoKey
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUsername = new System.Windows.Forms.Label();
            this.tfUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tfPassword = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.pnTest1 = new System.Windows.Forms.Panel();
            this.pnTest2 = new System.Windows.Forms.Panel();
            this.lbTest1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(184, 96);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(172, 33);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Benutzername";
            // 
            // tfUsername
            // 
            this.tfUsername.Location = new System.Drawing.Point(190, 137);
            this.tfUsername.Margin = new System.Windows.Forms.Padding(6);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(530, 31);
            this.tfUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(184, 248);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(172, 33);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "passwort";
            // 
            // tfPassword
            // 
            this.tfPassword.Location = new System.Drawing.Point(190, 310);
            this.tfPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Size = new System.Drawing.Size(530, 31);
            this.tfPassword.TabIndex = 3;
            this.tfPassword.UseSystemPasswordChar = true;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(572, 415);
            this.btRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(150, 44);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Registrieren";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(204, 415);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(178, 44);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pnTest1
            // 
            this.pnTest1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnTest1.Location = new System.Drawing.Point(899, 137);
            this.pnTest1.Name = "pnTest1";
            this.pnTest1.Size = new System.Drawing.Size(200, 100);
            this.pnTest1.TabIndex = 7;
            // 
            // pnTest2
            // 
            this.pnTest2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnTest2.Location = new System.Drawing.Point(899, 281);
            this.pnTest2.Name = "pnTest2";
            this.pnTest2.Size = new System.Drawing.Size(200, 100);
            this.pnTest2.TabIndex = 8;
            // 
            // lbTest1
            // 
            this.lbTest1.AutoSize = true;
            this.lbTest1.Location = new System.Drawing.Point(894, 434);
            this.lbTest1.Name = "lbTest1";
            this.lbTest1.Size = new System.Drawing.Size(48, 25);
            this.lbTest1.TabIndex = 9;
            this.lbTest1.Text = "Lan";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 546);
            this.Controls.Add(this.lbTest1);
            this.Controls.Add(this.pnTest2);
            this.Controls.Add(this.pnTest1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tfPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tfUsername);
            this.Controls.Add(this.lbUsername);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tfUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tfPassword;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel pnTest1;
        private System.Windows.Forms.Panel pnTest2;
        private System.Windows.Forms.Label lbTest1;
    }
}

