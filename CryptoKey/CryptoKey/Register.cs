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
    public partial class Register : Form
    {
        private Login ancestor;
        private CryptoKeyBL bl;
        public Register(Login ancestor , CryptoKeyBL bl)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            this.bl = bl;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ancestor.setVisible(true);
            this.Dispose();
        }

        public void setVisible(bool b)
        {
            this.SetVisibleCore(b);
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            try{
                bl.Register(tfUsername.Text, tfEmail.Text, tfpassword.Text);

            }
            catch(Exception x)
            {
                MessageBox.Show("" + x.Message);
            }
        }
    }
}
