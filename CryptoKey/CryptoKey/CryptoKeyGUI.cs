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
    public partial class CryptoKeyGUI : Form
    {
        private Login ancestor;
        private CryptoKeyBL bl;

        public CryptoKeyGUI(Login ancestor, CryptoKeyBL bl)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            this.bl = bl;
        }

        private void btchange_Click(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {

        }

        private void btdelete_Click(object sender, EventArgs e)
        {

        }

        public void setVisible(bool b)
        {
            this.SetVisibleCore(b);
        }
    }
}
