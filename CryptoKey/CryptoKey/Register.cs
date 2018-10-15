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
        private Login ancestor = new Login();
        public Register(Login ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
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
    }
}
