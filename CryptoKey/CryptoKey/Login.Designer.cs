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
            this.paBackground = new System.Windows.Forms.Panel();
            this.paDes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbUsername.Location = new System.Drawing.Point(368, 109);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(86, 25);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Benutzername";
            // 
            // tfUsername
            // 
            this.tfUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tfUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tfUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfUsername.ForeColor = System.Drawing.Color.White;
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
            this.lbPassword.Size = new System.Drawing.Size(86, 26);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Passwort";
            // 
            // tfPassword
            // 
            this.tfPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tfPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tfPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfPassword.ForeColor = System.Drawing.Color.White;
            this.tfPassword.Location = new System.Drawing.Point(372, 231);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Size = new System.Drawing.Size(267, 33);
            this.tfPassword.TabIndex = 3;
            this.tfPassword.UseSystemPasswordChar = true;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegister.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(539, 325);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(100, 32);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Registrieren";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLogin.Font = new System.Drawing.Font("Roboto Th", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(372, 325);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(100, 32);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // paBackground
            // 
            this.paBackground.BackColor = System.Drawing.Color.Silver;
            this.paBackground.Controls.Add(this.paDes);
            this.paBackground.Controls.Add(this.label1);
            this.paBackground.Controls.Add(this.lbUsername);
            this.paBackground.Controls.Add(this.btRegister);
            this.paBackground.Controls.Add(this.btLogin);
            this.paBackground.Controls.Add(this.tfUsername);
            this.paBackground.Controls.Add(this.lbPassword);
            this.paBackground.Controls.Add(this.tfPassword);
            this.paBackground.Location = new System.Drawing.Point(-6, -1);
            this.paBackground.Name = "paBackground";
            this.paBackground.Size = new System.Drawing.Size(682, 395);
            this.paBackground.TabIndex = 7;
            // 
            // paDes
            // 
            this.paDes.BackgroundImage = global::CryptoKey.Properties.Resources.bild;
            this.paDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paDes.Location = new System.Drawing.Point(4, 4);
            this.paDes.Name = "paDes";
            this.paDes.Size = new System.Drawing.Size(336, 388);
            this.paDes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Th", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(441, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Log In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 387);
            this.Controls.Add(this.paBackground);
            this.Name = "Login";
            this.Text = "Login";
            this.paBackground.ResumeLayout(false);
            this.paBackground.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paDes;
    }
}

