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
    public partial class Login : Form
    {
        private CryptoKeyBL bl = new CryptoKeyBL();
        public Login()
        {
            InitializeComponent();
        }


        public void setVisible(bool b)
        {
            this.SetVisibleCore(b);
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register(this, bl);
            this.setVisible(false);
            r.setVisible(true);

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bl.Login(tfUsername.Text, tfPassword.Text);
                pnTest1.BackColor = bl.Color;
                if (bl.Theme)
                {
                    pnTest2.BackColor = Color.White;
                } else
                {
                    pnTest2.BackColor = Color.Black;
                }
                if (bl.German)
                {
                    lbTest1.Text = "German";
                } else
                {
                    lbTest1.Text = "English";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
