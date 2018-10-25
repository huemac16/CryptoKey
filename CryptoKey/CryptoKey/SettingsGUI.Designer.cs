namespace CryptoKey
{
    partial class SettingsGUI
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
            this.paDes = new System.Windows.Forms.Panel();
            this.lbSettings = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbusercol = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbGerman = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ThemeSelector = new System.Windows.Forms.TabControl();
            this.rbbrightt = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbdarkt = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.ThemeSelector.SuspendLayout();
            this.rbbrightt.SuspendLayout();
            this.rbdarkt.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // paDes
            // 
            this.paDes.AutoSize = true;
            this.paDes.BackgroundImage = global::CryptoKey.Properties.Resources.bild;
            this.paDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paDes.Location = new System.Drawing.Point(0, 0);
            this.paDes.Margin = new System.Windows.Forms.Padding(6);
            this.paDes.Name = "paDes";
            this.paDes.Size = new System.Drawing.Size(672, 793);
            this.paDes.TabIndex = 9;
            // 
            // lbSettings
            // 
            this.lbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lbSettings.Location = new System.Drawing.Point(677, 18);
            this.lbSettings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(664, 88);
            this.lbSettings.TabIndex = 14;
            this.lbSettings.Text = "Einstellungen";
            // 
            // lbColor
            // 
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbColor.Location = new System.Drawing.Point(684, 154);
            this.lbColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(142, 46);
            this.lbColor.TabIndex = 15;
            this.lbColor.Text = "Farbe";
            // 
            // lbusercol
            // 
            this.lbusercol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbusercol.Location = new System.Drawing.Point(696, 239);
            this.lbusercol.Name = "lbusercol";
            this.lbusercol.Size = new System.Drawing.Size(92, 46);
            this.lbusercol.TabIndex = 16;
            // 
            // btChange
            // 
            this.btChange.BackColor = System.Drawing.Color.Navy;
            this.btChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.ForeColor = System.Drawing.Color.White;
            this.btChange.Location = new System.Drawing.Point(692, 313);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(181, 67);
            this.btChange.TabIndex = 17;
            this.btChange.Text = "Ändern";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(887, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 46);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sprache";
            // 
            // rbGerman
            // 
            this.rbGerman.AutoSize = true;
            this.rbGerman.Location = new System.Drawing.Point(0, 19);
            this.rbGerman.Name = "rbGerman";
            this.rbGerman.Size = new System.Drawing.Size(122, 29);
            this.rbGerman.TabIndex = 19;
            this.rbGerman.TabStop = true;
            this.rbGerman.Text = "Deutsch";
            this.rbGerman.UseVisualStyleBackColor = true;
            this.rbGerman.CheckedChanged += new System.EventHandler(this.rbGerman_CheckedChanged);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(0, 54);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(125, 29);
            this.rbEnglish.TabIndex = 20;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Englisch";
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGerman);
            this.groupBox1.Controls.Add(this.rbEnglish);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(895, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 112);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(1133, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 22;
            this.label2.Text = "Theme";
            // 
            // ThemeSelector
            // 
            this.ThemeSelector.Controls.Add(this.rbbrightt);
            this.ThemeSelector.Controls.Add(this.rbdarkt);
            this.ThemeSelector.Location = new System.Drawing.Point(1141, 212);
            this.ThemeSelector.Name = "ThemeSelector";
            this.ThemeSelector.SelectedIndex = 0;
            this.ThemeSelector.Size = new System.Drawing.Size(307, 176);
            this.ThemeSelector.TabIndex = 23;
            this.ThemeSelector.SelectedIndexChanged += new System.EventHandler(this.chnageTheme);
            // 
            // rbbrightt
            // 
            this.rbbrightt.Controls.Add(this.panel1);
            this.rbbrightt.Location = new System.Drawing.Point(8, 39);
            this.rbbrightt.Name = "rbbrightt";
            this.rbbrightt.Padding = new System.Windows.Forms.Padding(3);
            this.rbbrightt.Size = new System.Drawing.Size(291, 129);
            this.rbbrightt.TabIndex = 0;
            this.rbbrightt.Text = "BrightTheme";
            this.rbbrightt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 44);
            this.panel1.TabIndex = 24;
            // 
            // rbdarkt
            // 
            this.rbdarkt.BackColor = System.Drawing.Color.DimGray;
            this.rbdarkt.Controls.Add(this.panel2);
            this.rbdarkt.Location = new System.Drawing.Point(8, 39);
            this.rbdarkt.Name = "rbdarkt";
            this.rbdarkt.Padding = new System.Windows.Forms.Padding(3);
            this.rbdarkt.Size = new System.Drawing.Size(291, 129);
            this.rbdarkt.TabIndex = 1;
            this.rbdarkt.Text = "DarkTheme";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 44);
            this.panel2.TabIndex = 25;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btCancel.BackgroundImage = global::CryptoKey.Properties.Resources.x1;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCancel.Location = new System.Drawing.Point(1261, 533);
            this.btCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(114, 85);
            this.btCancel.TabIndex = 25;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.Gainsboro;
            this.btsave.BackgroundImage = global::CryptoKey.Properties.Resources.addUserFinal2;
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btsave.Location = new System.Drawing.Point(743, 533);
            this.btsave.Margin = new System.Windows.Forms.Padding(6);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(114, 85);
            this.btsave.TabIndex = 24;
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Controls.Add(this.paDes);
            this.panel3.Controls.Add(this.lbSettings);
            this.panel3.Controls.Add(this.btChange);
            this.panel3.Controls.Add(this.btsave);
            this.panel3.Controls.Add(this.lbusercol);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbColor);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.ThemeSelector);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1481, 746);
            this.panel3.TabIndex = 26;
            // 
            // SettingsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1464, 682);
            this.Controls.Add(this.panel3);
            this.Name = "SettingsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ThemeSelector.ResumeLayout(false);
            this.rbbrightt.ResumeLayout(false);
            this.rbdarkt.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paDes;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbusercol;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbGerman;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl ThemeSelector;
        private System.Windows.Forms.TabPage rbbrightt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage rbdarkt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}