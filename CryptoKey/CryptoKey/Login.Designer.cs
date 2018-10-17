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
            this.paBackground = new System.Windows.Forms.Panel();
            this.lnLogIn = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.paDes = new System.Windows.Forms.Panel();
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.paBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbUsername.Location = new System.Drawing.Point(368, 109);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(129, 24);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Benutzername";
            // 
            // tfUsername
            // 
            this.tfUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tfUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tfUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfUsername.ForeColor = System.Drawing.Color.Black;
            this.tfUsername.Location = new System.Drawing.Point(372, 137);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(267, 33);
            this.tfUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbPassword.Location = new System.Drawing.Point(368, 202);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(85, 24);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Passwort";
            // 
            // tfPassword
            // 
            this.tfPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tfPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tfPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfPassword.ForeColor = System.Drawing.Color.Black;
            this.tfPassword.Location = new System.Drawing.Point(372, 231);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Size = new System.Drawing.Size(267, 33);
            this.tfPassword.TabIndex = 3;
            this.tfPassword.UseSystemPasswordChar = true;
            // 
            // paBackground
            // 
            this.paBackground.BackColor = System.Drawing.Color.Gainsboro;
            this.paBackground.Controls.Add(this.pbClose);
            this.paBackground.Controls.Add(this.paDes);
            this.paBackground.Controls.Add(this.lnLogIn);
            this.paBackground.Controls.Add(this.lbUsername);
            this.paBackground.Controls.Add(this.btRegister);
            this.paBackground.Controls.Add(this.btLogin);
            this.paBackground.Controls.Add(this.tfUsername);
            this.paBackground.Controls.Add(this.lbPassword);
            this.paBackground.Controls.Add(this.tfPassword);
            this.paBackground.ForeColor = System.Drawing.Color.Transparent;
            this.paBackground.Location = new System.Drawing.Point(-6, -1);
            this.paBackground.Name = "paBackground";
            this.paBackground.Size = new System.Drawing.Size(682, 409);
            this.paBackground.TabIndex = 7;
            // 
            // lnLogIn
            // 
            this.lnLogIn.Font = new System.Drawing.Font("Roboto Th", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lnLogIn.Location = new System.Drawing.Point(445, 21);
            this.lnLogIn.Name = "lnLogIn";
            this.lnLogIn.Size = new System.Drawing.Size(119, 46);
            this.lnLogIn.TabIndex = 7;
            this.lnLogIn.Text = "Log In";
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::CryptoKey.Properties.Resources.close;
            this.pbClose.ErrorImage = global::CryptoKey.Properties.Resources.close;
            this.pbClose.InitialImage = global::CryptoKey.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(642, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(34, 23);
            this.pbClose.TabIndex = 9;
            this.pbClose.TabStop = false;
            this.pbClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close);
            // 
            // paDes
            // 
            this.paDes.BackgroundImage = global::CryptoKey.Properties.Resources.bild;
            this.paDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paDes.Location = new System.Drawing.Point(4, 0);
            this.paDes.Name = "paDes";
            this.paDes.Size = new System.Drawing.Size(336, 406);
            this.paDes.TabIndex = 8;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Transparent;
            this.btRegister.BackgroundImage = global::CryptoKey.Properties.Resources.user_add_real;
            this.btRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btRegister.Location = new System.Drawing.Point(567, 299);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(57, 43);
            this.btRegister.TabIndex = 5;
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.BackgroundImage = global::CryptoKey.Properties.Resources.login;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btLogin.Location = new System.Drawing.Point(396, 298);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(57, 44);
            this.btLogin.TabIndex = 6;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 387);
            this.Controls.Add(this.paBackground);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.paBackground.ResumeLayout(false);
            this.paBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tfUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tfPassword;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel paBackground;
        private System.Windows.Forms.Label lnLogIn;
        private System.Windows.Forms.Panel paDes;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

