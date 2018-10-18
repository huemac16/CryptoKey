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
            this.AccountList = new System.Windows.Forms.ListBox();
            this.btlogout = new System.Windows.Forms.Button();
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
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btchange = new System.Windows.Forms.Button();
            this.btsort1 = new System.Windows.Forms.Button();
            this.btsort2 = new System.Windows.Forms.Button();
            this.btsort3 = new System.Windows.Forms.Button();
            this.tffilter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountList
            // 
            this.AccountList.FormattingEnabled = true;
            this.AccountList.ItemHeight = 25;
            this.AccountList.Location = new System.Drawing.Point(80, 85);
            this.AccountList.Margin = new System.Windows.Forms.Padding(4);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(956, 929);
            this.AccountList.TabIndex = 1;
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(1335, 13);
            this.btlogout.Margin = new System.Windows.Forms.Padding(4);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(106, 44);
            this.btlogout.TabIndex = 20;
            this.btlogout.Text = "Abmelden";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbH);
            this.groupBox1.Controls.Add(this.rbL);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Location = new System.Drawing.Point(1080, 544);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(337, 185);
            this.groupBox1.TabIndex = 35;
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
            this.label5.Location = new System.Drawing.Point(1076, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Url";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1072, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1076, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1076, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Email";
            // 
            // tfurl
            // 
            this.tfurl.Location = new System.Drawing.Point(1076, 490);
            this.tfurl.Margin = new System.Windows.Forms.Padding(4);
            this.tfurl.Name = "tfurl";
            this.tfurl.Size = new System.Drawing.Size(382, 31);
            this.tfurl.TabIndex = 29;
            this.tfurl.Text = "https://www.yahoo.com";
            // 
            // tfusername
            // 
            this.tfusername.Location = new System.Drawing.Point(1076, 417);
            this.tfusername.Margin = new System.Windows.Forms.Padding(4);
            this.tfusername.Name = "tfusername";
            this.tfusername.Size = new System.Drawing.Size(382, 31);
            this.tfusername.TabIndex = 28;
            this.tfusername.Text = "Marcel";
            // 
            // tfpassword
            // 
            this.tfpassword.Location = new System.Drawing.Point(1076, 340);
            this.tfpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tfpassword.Name = "tfpassword";
            this.tfpassword.Size = new System.Drawing.Size(382, 31);
            this.tfpassword.TabIndex = 27;
            this.tfpassword.Text = "yahooPW";
            this.tfpassword.UseSystemPasswordChar = true;
            // 
            // tfemail
            // 
            this.tfemail.Location = new System.Drawing.Point(1076, 263);
            this.tfemail.Margin = new System.Windows.Forms.Padding(4);
            this.tfemail.Name = "tfemail";
            this.tfemail.Size = new System.Drawing.Size(382, 31);
            this.tfemail.TabIndex = 26;
            this.tfemail.Text = "dev-yahoo@gmx.at";
            // 
            // tftitle
            // 
            this.tftitle.Location = new System.Drawing.Point(1076, 190);
            this.tftitle.Margin = new System.Windows.Forms.Padding(4);
            this.tftitle.Name = "tftitle";
            this.tftitle.Size = new System.Drawing.Size(382, 31);
            this.tftitle.TabIndex = 25;
            this.tftitle.Text = "Yahoo";
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(1064, 817);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(108, 52);
            this.btdelete.TabIndex = 24;
            this.btdelete.Text = "Löschen";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(1180, 757);
            this.btadd.Margin = new System.Windows.Forms.Padding(4);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(172, 52);
            this.btadd.TabIndex = 23;
            this.btadd.Text = "Hinzufügen";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btchange
            // 
            this.btchange.Location = new System.Drawing.Point(1064, 757);
            this.btchange.Margin = new System.Windows.Forms.Padding(4);
            this.btchange.Name = "btchange";
            this.btchange.Size = new System.Drawing.Size(108, 52);
            this.btchange.TabIndex = 22;
            this.btchange.Text = "Ändern";
            this.btchange.UseVisualStyleBackColor = true;
            this.btchange.Click += new System.EventHandler(this.btchange_Click);
            // 
            // btsort1
            // 
            this.btsort1.Location = new System.Drawing.Point(1064, 890);
            this.btsort1.Name = "btsort1";
            this.btsort1.Size = new System.Drawing.Size(129, 44);
            this.btsort1.TabIndex = 36;
            this.btsort1.Text = "Priorität";
            this.btsort1.UseVisualStyleBackColor = true;
            this.btsort1.Click += new System.EventHandler(this.btsort1_Click);
            // 
            // btsort2
            // 
            this.btsort2.Location = new System.Drawing.Point(1199, 890);
            this.btsort2.Name = "btsort2";
            this.btsort2.Size = new System.Drawing.Size(129, 44);
            this.btsort2.TabIndex = 37;
            this.btsort2.Text = "Markiert";
            this.btsort2.UseVisualStyleBackColor = true;
            this.btsort2.Click += new System.EventHandler(this.btsort2_Click);
            // 
            // btsort3
            // 
            this.btsort3.Location = new System.Drawing.Point(1335, 890);
            this.btsort3.Name = "btsort3";
            this.btsort3.Size = new System.Drawing.Size(129, 44);
            this.btsort3.TabIndex = 38;
            this.btsort3.Text = "Alphabet";
            this.btsort3.UseVisualStyleBackColor = true;
            this.btsort3.Click += new System.EventHandler(this.btsort3_Click);
            // 
            // tffilter
            // 
            this.tffilter.Location = new System.Drawing.Point(1064, 960);
            this.tffilter.Name = "tffilter";
            this.tffilter.Size = new System.Drawing.Size(400, 31);
            this.tffilter.TabIndex = 39;
            this.tffilter.TextChanged += new System.EventHandler(this.ApplyFilter);
            // 
            // CryptoKeyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1062);
            this.Controls.Add(this.tffilter);
            this.Controls.Add(this.btsort3);
            this.Controls.Add(this.btsort2);
            this.Controls.Add(this.btsort1);
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
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.AccountList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CryptoKeyGUI";
            this.Text = "CryptoKeyGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AccountList;
        private System.Windows.Forms.Button btlogout;
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
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btchange;
        private System.Windows.Forms.Button btsort1;
        private System.Windows.Forms.Button btsort2;
        private System.Windows.Forms.Button btsort3;
        private System.Windows.Forms.TextBox tffilter;
    }
}