namespace CryptoKey
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tfurl = new System.Windows.Forms.TextBox();
            this.tfusername = new System.Windows.Forms.TextBox();
            this.tfpassword = new System.Windows.Forms.TextBox();
            this.tfemail = new System.Windows.Forms.TextBox();
            this.tftitle = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbH);
            this.groupBox1.Controls.Add(this.rbL);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Location = new System.Drawing.Point(175, 403);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(337, 185);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priorität";
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(84, 48);
            this.rbH.Margin = new System.Windows.Forms.Padding(4);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(90, 29);
            this.rbH.TabIndex = 15;
            this.rbH.Text = "hoch";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Location = new System.Drawing.Point(84, 119);
            this.rbL.Margin = new System.Windows.Forms.Padding(4);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(108, 29);
            this.rbL.TabIndex = 17;
            this.rbL.Text = "niedrig";
            this.rbL.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Location = new System.Drawing.Point(84, 85);
            this.rbM.Margin = new System.Windows.Forms.Padding(4);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(94, 29);
            this.rbM.TabIndex = 16;
            this.rbM.TabStop = true;
            this.rbM.Text = "mittel";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Url";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email";
            // 
            // tfurl
            // 
            this.tfurl.Location = new System.Drawing.Point(171, 349);
            this.tfurl.Margin = new System.Windows.Forms.Padding(4);
            this.tfurl.Name = "tfurl";
            this.tfurl.Size = new System.Drawing.Size(382, 31);
            this.tfurl.TabIndex = 25;
            this.tfurl.Text = "https://www.yahoo.com";
            // 
            // tfusername
            // 
            this.tfusername.Location = new System.Drawing.Point(171, 276);
            this.tfusername.Margin = new System.Windows.Forms.Padding(4);
            this.tfusername.Name = "tfusername";
            this.tfusername.Size = new System.Drawing.Size(382, 31);
            this.tfusername.TabIndex = 24;
            this.tfusername.Text = "Marcel";
            // 
            // tfpassword
            // 
            this.tfpassword.Location = new System.Drawing.Point(171, 199);
            this.tfpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tfpassword.Name = "tfpassword";
            this.tfpassword.Size = new System.Drawing.Size(382, 31);
            this.tfpassword.TabIndex = 23;
            this.tfpassword.Text = "yahooPW";
            this.tfpassword.UseSystemPasswordChar = true;
            // 
            // tfemail
            // 
            this.tfemail.Location = new System.Drawing.Point(171, 122);
            this.tfemail.Margin = new System.Windows.Forms.Padding(4);
            this.tfemail.Name = "tfemail";
            this.tfemail.Size = new System.Drawing.Size(382, 31);
            this.tfemail.TabIndex = 22;
            this.tfemail.Text = "dev-yahoo@gmx.at";
            // 
            // tftitle
            // 
            this.tftitle.Location = new System.Drawing.Point(171, 49);
            this.tftitle.Margin = new System.Windows.Forms.Padding(4);
            this.tftitle.Name = "tftitle";
            this.tftitle.Size = new System.Drawing.Size(382, 31);
            this.tftitle.TabIndex = 21;
            this.tftitle.Text = "Yahoo";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(237, 608);
            this.btadd.Margin = new System.Windows.Forms.Padding(4);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(172, 52);
            this.btadd.TabIndex = 20;
            this.btadd.Text = "Hinzufügen";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfurl);
            this.Controls.Add(this.tfusername);
            this.Controls.Add(this.tfpassword);
            this.Controls.Add(this.tfemail);
            this.Controls.Add(this.tftitle);
            this.Controls.Add(this.btadd);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfurl;
        private System.Windows.Forms.TextBox tfusername;
        private System.Windows.Forms.TextBox tfpassword;
        private System.Windows.Forms.TextBox tfemail;
        private System.Windows.Forms.TextBox tftitle;
        private System.Windows.Forms.Button btadd;
    }
}