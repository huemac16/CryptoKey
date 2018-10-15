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
                String username = tfUsername.Text;
                String email = tfEmail.Text;
                String password = tfpassword.Text;
                String password2 = tfPassword2.Text;

                if(email.Contains("@") && email.Contains(".") && !(username.Contains("@")))
                {
                    if(this.correctPassword(password))
                    {
                        if(this.samePasswords(password, password2))
                        {
                            bl.Register(tfUsername.Text, tfEmail.Text, tfpassword.Text);
                        }
                    }

                }
                else
                {

                }






                

            }
            catch(Exception x)
            {
                MessageBox.Show("" + x.Message);
            }
        }

        public bool correctPassword(String pw)
        {
            if(pw.Any(char.IsUpper) && pw.Any(char.IsLower) && pw.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public bool samePasswords(String pw1, String pw2)
        {
            if(pw1.Equals(pw2))
            {
                return true;
            }

            return false;
        }
    }
}
