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
            bl.InitAccounts(AccountList,"");
        }

        private void btchange_Click(object sender, EventArgs e)
        {
            try
            {
                char p = '2';
                if (rbH.Checked) p = '3';
                else if (rbL.Checked) p = '1';
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
                char p = '2';
                if (rbH.Checked) p = '3';
                else if (rbL.Checked) p = '1';
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

        private void ApplyFilter(object sender, EventArgs e)
        {
            bl.filter(tffilter.Text);
            bl.update(AccountList);
        }

        private void btsort1_Click(object sender, EventArgs e)
        {
            bl.InitAccounts(AccountList,"priority DESC, title ASC");
        }

        private void btsort2_Click(object sender, EventArgs e)
        {
            bl.InitAccounts(AccountList, "marked DESC, title ASC");
        }

        private void btsort3_Click(object sender, EventArgs e)
        {
            bl.InitAccounts(AccountList, "title ASC");
        }
    }
}
