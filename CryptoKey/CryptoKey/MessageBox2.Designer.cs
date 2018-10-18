namespace CryptoKey
{
    partial class MessageBox2
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
            this.tfmessage = new System.Windows.Forms.Label();
            this.btdeny = new System.Windows.Forms.Button();
            this.btok = new System.Windows.Forms.Button();
            this.lbtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tfmessage
            // 
            this.tfmessage.BackColor = System.Drawing.Color.Transparent;
            this.tfmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfmessage.Location = new System.Drawing.Point(15, 94);
            this.tfmessage.Name = "tfmessage";
            this.tfmessage.Size = new System.Drawing.Size(815, 175);
            this.tfmessage.TabIndex = 8;
            // 
            // btdeny
            // 
            this.btdeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeny.ForeColor = System.Drawing.Color.White;
            this.btdeny.Location = new System.Drawing.Point(530, 284);
            this.btdeny.Name = "btdeny";
            this.btdeny.Size = new System.Drawing.Size(240, 45);
            this.btdeny.TabIndex = 7;
            this.btdeny.Text = "Nein";
            this.btdeny.UseVisualStyleBackColor = true;
            this.btdeny.Click += new System.EventHandler(this.btdeny_Click);
            // 
            // btok
            // 
            this.btok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btok.ForeColor = System.Drawing.Color.White;
            this.btok.Location = new System.Drawing.Point(68, 284);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(256, 45);
            this.btok.TabIndex = 6;
            this.btok.Text = "Ja";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // lbtitle
            // 
            this.lbtitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbtitle.Location = new System.Drawing.Point(-23, -4);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(882, 85);
            this.lbtitle.TabIndex = 5;
            this.lbtitle.Text = "Warnung";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 344);
            this.Controls.Add(this.tfmessage);
            this.Controls.Add(this.btdeny);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.lbtitle);
            this.Name = "MessageBox2";
            this.Text = "MessageBox2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tfmessage;
        private System.Windows.Forms.Button btdeny;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Label lbtitle;
    }
}