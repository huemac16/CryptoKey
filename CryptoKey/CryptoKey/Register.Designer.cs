namespace CryptoKey
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.tfEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tfUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tfpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tfPassword2 = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // tfEmail
            // 
            this.tfEmail.Location = new System.Drawing.Point(60, 78);
            this.tfEmail.Name = "tfEmail";
            this.tfEmail.Size = new System.Drawing.Size(277, 20);
            this.tfEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Benutzername";
            // 
            // tfUsername
            // 
            this.tfUsername.Location = new System.Drawing.Point(60, 164);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(277, 20);
            this.tfUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(57, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passwort";
            // 
            // tfpassword
            // 
            this.tfpassword.Location = new System.Drawing.Point(60, 255);
            this.tfpassword.Name = "tfpassword";
            this.tfpassword.Size = new System.Drawing.Size(277, 20);
            this.tfpassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(57, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passwort wiederholen";
            // 
            // tfPassword2
            // 
            this.tfPassword2.Location = new System.Drawing.Point(60, 349);
            this.tfPassword2.Name = "tfPassword2";
            this.tfPassword2.Size = new System.Drawing.Size(277, 20);
            this.tfPassword2.TabIndex = 7;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(60, 421);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(120, 23);
            this.btRegister.TabIndex = 8;
            this.btRegister.Text = "Registrieren";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(242, 421);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Abbrechen";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 512);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tfPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tfpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tfUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfEmail);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tfpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tfPassword2;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btCancel;
    }
}