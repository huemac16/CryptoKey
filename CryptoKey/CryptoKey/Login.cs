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
<<<<<<< HEAD

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bl.Login(tfUsername.Text, tfPassword.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
=======
>>>>>>> a55a73b177c1183a6c13de488d2f8030a432b0fc
    }
}
