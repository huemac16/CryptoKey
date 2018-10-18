using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKey
{
    public partial class MessageBox2 : Form
    {
        private bool ok;

        public bool Ok
        {
            get { return ok; }
            set { ok = value; }
        }


        public MessageBox2(string txt, Color color, bool theme, bool lan)
        {
            InitializeComponent();
            btok.FlatAppearance.BorderSize = 0;
            btdeny.FlatAppearance.BorderSize = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            btok.Focus();
            tfmessage.Text = txt;
            btok.BackColor = color;
            btdeny.BackColor = color;
            if (color.R + color.G + color.B < 500)
            {
                btok.ForeColor = Color.FromArgb(230, 230, 230);
                btdeny.ForeColor = Color.FromArgb(230, 230, 230);
            }
            else
            {
                btok.ForeColor = Color.FromArgb(50, 50, 50);
                btdeny.ForeColor = Color.FromArgb(50, 50, 50);
            }
            if (theme)
            {
                this.BackColor = Color.FromArgb(90, 90, 90);
                tfmessage.BackColor = Color.FromArgb(90, 90, 90);
                tfmessage.ForeColor = Color.FromArgb(230, 230, 230);
                lbtitle.BackColor = Color.FromArgb(50, 50, 50);
                lbtitle.ForeColor = Color.FromArgb(240, 240, 240);
            }
            if (lan)
            {
                lbtitle.Text = "Warning";
                btdeny.Text = "No";
                btok.Text = "Yes";
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            ok = true;
        }

        private void btdeny_Click(object sender, EventArgs e)
        {
            ok = false;
        }

        public void setVisible(bool b)
        {
            this.SetVisibleCore(b);
        }
    }
}
