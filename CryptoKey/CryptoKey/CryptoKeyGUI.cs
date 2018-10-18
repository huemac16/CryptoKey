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
            //bl.InitAccounts(AccountList);
        }

        private void btchange_Click(object sender, EventArgs e)
        {
            try
            {
                char p = 'M';
                if (rbH.Checked) p = 'H';
                else if (rbL.Checked) p = 'L';
                bl.change(AccountList.SelectedIndex, new Account { id = ((Account) bl.Accounts[AccountList.SelectedIndex]).id, Email = tfemail.Text, Title = tftitle.Text, Password = tfpassword.Text, Onlineuser = tfusername.Text, Url = tfurl.Text, Priority = p }, AccountList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                char p = 'M';
                if (rbH.Checked) p = 'H';
                else if (rbL.Checked) p = 'L';
                bl.add(new Account { Email = tfemail.Text, Title = tftitle.Text, Password = tfpassword.Text, Onlineuser = tfusername.Text, Url = tfurl.Text, Priority = p},AccountList);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                bl.delete((Account)bl.Accounts[AccountList.SelectedIndex],AccountList);
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

        private void btlogout_Click(object sender, EventArgs e)
        {
            bl.Logout();
            this.setVisible(false);
            ancestor.setVisible(true);
            ancestor.ClearTF();
        }

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            bl.Logout();
            Dispose();
            ancestor.Dispose();
        }

       
    }
}
