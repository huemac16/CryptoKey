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
    public partial class AddForm : Form
    {
        private CryptoKeyGUI ancestor;
        private CryptoKeyBL bl;
        private ListBox list;

        public AddForm(CryptoKeyGUI ancestor, CryptoKeyBL bl, ListBox list)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            this.bl = bl;
            this.list = list;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                char p = 'M';
                if (rbH.Checked) p = 'H';
                else if (rbL.Checked) p = 'L';
                bl.add(new Account { Email = tfemail.Text, Title = tftitle.Text, Password = tfpassword.Text, Onlineuser = tfusername.Text, Url = tfurl.Text, Priority = p }, list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void setVisible(bool b)
        {
            this.SetVisibleCore(b);
        }
    }
}
