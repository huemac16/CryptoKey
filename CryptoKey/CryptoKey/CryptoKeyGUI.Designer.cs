namespace CryptoKey
{
    partial class CryptoKeyGUI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btchange = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.tftitle = new System.Windows.Forms.TextBox();
            this.tfemail = new System.Windows.Forms.TextBox();
            this.tfpassword = new System.Windows.Forms.TextBox();
            this.tfusername = new System.Windows.Forms.TextBox();
            this.tfurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmarked = new System.Windows.Forms.CheckBox();
            this.btlogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(81, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(956, 929);
            this.listBox1.TabIndex = 1;
            // 
            // btchange
            // 
            this.btchange.Location = new System.Drawing.Point(1057, 725);
            this.btchange.Name = "btchange";
            this.btchange.Size = new System.Drawing.Size(266, 51);
            this.btchange.TabIndex = 2;
            this.btchange.Text = "Ändern";
            this.btchange.UseVisualStyleBackColor = true;
            this.btchange.Click += new System.EventHandler(this.btchange_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(1346, 725);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(266, 51);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "Hinzufügen";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(1057, 836);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(266, 51);
            this.btdelete.TabIndex = 4;
            this.btdelete.Text = "Löschen";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // tftitle
            // 
            this.tftitle.Location = new System.Drawing.Point(1068, 158);
            this.tftitle.Name = "tftitle";
            this.tftitle.Size = new System.Drawing.Size(541, 31);
            this.tftitle.TabIndex = 5;
            this.tftitle.Text = "Yahoo";
            // 
            // tfemail
            // 
            this.tfemail.Location = new System.Drawing.Point(1068, 231);
            this.tfemail.Name = "tfemail";
            this.tfemail.Size = new System.Drawing.Size(541, 31);
            this.tfemail.TabIndex = 6;
            this.tfemail.Text = "dev-yahoo@gmx.at";
            // 
            // tfpassword
            // 
            this.tfpassword.Location = new System.Drawing.Point(1068, 307);
            this.tfpassword.Name = "tfpassword";
            this.tfpassword.Size = new System.Drawing.Size(541, 31);
            this.tfpassword.TabIndex = 7;
            this.tfpassword.Text = "yahooPW";
            // 
            // tfusername
            // 
            this.tfusername.Location = new System.Drawing.Point(1068, 384);
            this.tfusername.Name = "tfusername";
            this.tfusername.Size = new System.Drawing.Size(541, 31);
            this.tfusername.TabIndex = 8;
            this.tfusername.Text = "Marcel";
            // 
            // tfurl
            // 
            this.tfurl.Location = new System.Drawing.Point(1068, 457);
            this.tfurl.Name = "tfurl";
            this.tfurl.Size = new System.Drawing.Size(541, 31);
            this.tfurl.TabIndex = 9;
            this.tfurl.Text = "https://www.yahoo.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1068, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Passwort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1063, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1063, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1068, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Url";
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(85, 49);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(90, 29);
            this.rbH.TabIndex = 15;
            this.rbH.Text = "hoch";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Location = new System.Drawing.Point(85, 85);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(94, 29);
            this.rbM.TabIndex = 16;
            this.rbM.TabStop = true;
            this.rbM.Text = "mittel";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Location = new System.Drawing.Point(85, 120);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(108, 29);
            this.rbL.TabIndex = 17;
            this.rbL.Text = "niedrig";
            this.rbL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbH);
            this.groupBox1.Controls.Add(this.rbL);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Location = new System.Drawing.Point(1073, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 185);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priorität";
            // 
            // cbmarked
            // 
            this.cbmarked.AutoSize = true;
            this.cbmarked.Location = new System.Drawing.Point(1424, 598);
            this.cbmarked.Name = "cbmarked";
            this.cbmarked.Size = new System.Drawing.Size(121, 29);
            this.cbmarked.TabIndex = 19;
            this.cbmarked.Text = "markiert";
            this.cbmarked.UseVisualStyleBackColor = true;
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(1346, 13);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(263, 45);
            this.btlogout.TabIndex = 20;
            this.btlogout.Text = "Abmelden";
            this.btlogout.UseVisualStyleBackColor = true;
            // 
            // CryptoKeyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1122);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.cbmarked);
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
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btchange);
            this.Controls.Add(this.listBox1);
            this.Name = "CryptoKeyGUI";
            this.Text = "CryptoKeyGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btchange;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox tftitle;
        private System.Windows.Forms.TextBox tfemail;
        private System.Windows.Forms.TextBox tfpassword;
        private System.Windows.Forms.TextBox tfusername;
        private System.Windows.Forms.TextBox tfurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbmarked;
        private System.Windows.Forms.Button btlogout;
    }
}