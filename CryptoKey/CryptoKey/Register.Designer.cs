﻿namespace CryptoKey
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tfEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tfUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tfpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tfPassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.passwordProgressBar = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnback = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(348, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // tfEmail
            // 
            this.tfEmail.Location = new System.Drawing.Point(351, 135);
            this.tfEmail.Name = "tfEmail";
            this.tfEmail.Size = new System.Drawing.Size(277, 20);
            this.tfEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(348, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Benutzername";
            // 
            // tfUsername
            // 
            this.tfUsername.Location = new System.Drawing.Point(351, 221);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(277, 20);
            this.tfUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(348, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passwort";
            // 
            // tfpassword
            // 
            this.tfpassword.Location = new System.Drawing.Point(351, 312);
            this.tfpassword.Name = "tfpassword";
            this.tfpassword.Size = new System.Drawing.Size(277, 20);
            this.tfpassword.TabIndex = 5;
            this.tfpassword.UseSystemPasswordChar = true;
            this.tfpassword.TextChanged += new System.EventHandler(this.textChanged);
            this.tfpassword.MouseHover += new System.EventHandler(this.hover);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto Th", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(348, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passwort wiederholen";
            // 
            // tfPassword2
            // 
            this.tfPassword2.Location = new System.Drawing.Point(351, 406);
            this.tfPassword2.Name = "tfPassword2";
            this.tfPassword2.Size = new System.Drawing.Size(277, 20);
            this.tfPassword2.TabIndex = 7;
            this.tfPassword2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto Th", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registrieren";
            // 
            // btCancel
            // 
            this.btCancel.BackgroundImage = global::CryptoKey.Properties.Resources.x1;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCancel.Location = new System.Drawing.Point(530, 469);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(57, 44);
            this.btCancel.TabIndex = 9;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Gainsboro;
            this.btRegister.BackgroundImage = global::CryptoKey.Properties.Resources.addUserFinal2;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btRegister.Location = new System.Drawing.Point(391, 469);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(57, 44);
            this.btRegister.TabIndex = 8;
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // passwordProgressBar
            // 
            this.passwordProgressBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.passwordProgressBar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.passwordProgressBar.Location = new System.Drawing.Point(352, 339);
            this.passwordProgressBar.Name = "passwordProgressBar";
            this.passwordProgressBar.Size = new System.Drawing.Size(276, 3);
            this.passwordProgressBar.Step = 25;
            this.passwordProgressBar.TabIndex = 12;
            // 
            // pnback
            // 
            this.pnback.Location = new System.Drawing.Point(335, 12);
            this.pnback.Name = "pnback";
            this.pnback.Size = new System.Drawing.Size(333, 512);
            this.pnback.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CryptoKey.Properties.Resources.bildRegister;
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 548);
            this.panel1.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(662, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordProgressBar);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.pnback);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar passwordProgressBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnback;
        private System.Windows.Forms.Panel panel1;
    }
}