using System;
using System.Collections;
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
        private int curr = 0;
        public Register(Login ancestor , CryptoKeyBL bl)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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

                if (email.Contains("@") && email.Contains(".") && !(username.Contains("@")))
                {

                    if (this.correctPassword(password))
                    {

                        if (this.samePasswords(password, password2))
                        {
                            bl.Register(tfUsername.Text, tfEmail.Text, EncryptionHelper.Encrypt(tfpassword.Text));
                            MessageBox.Show("Ihr Account wurde erfolgreich erstellt");
                            this.setVisible(false);
                            ancestor.setVisible(true);
                        }
                        else
                        {
                            MessageBox.Show("Die beiden Passwörter stimmen nicht überein");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Das Passwort erfüllt nicht die vorgegebenen Bedienungen. Das Passwort muss" +
                            "mindestens einen Großbuchstaben, einen Kleinbuchstaben und mindestens eine Ziffer enthalten. " +
                            "Außerdem muss das Passwort eine Mindestlänge von 8 Zeichen haben!");
                    }

                }
                else
                {
                    MessageBox.Show("Ungültige Email Adresse oder Benutzername!");


                }


            }
            catch(Exception x)
            {
                MessageBox.Show("" + x.Message);
            }
        }

        public bool correctPassword(String pw)
        {
            if(pw.Any(char.IsUpper) && pw.Any(char.IsLower) && pw.Any(c => char.IsDigit(c)) && pw.Length >= 8)
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

        private void textChanged(object sender, EventArgs e)
        {
            Console.WriteLine("jajaaaa");
            string text = tfpassword.Text;
            bool low = false;
            bool upp = false;
            bool dig = false;
            bool len = false;
            ArrayList list = new ArrayList();


            if (text.Any(char.IsUpper))
            {
                upp = true;
                
            }
            if(text.Any(char.IsLower))
            {
                low = true;
            }
            if(text.Any(c => char.IsDigit(c)))
            {
                dig = true;
            }
            if(text.Length >= 8)
            {
                len = true;
            }
            list.Add(low);
            list.Add(upp);
            list.Add(dig);
            list.Add(len);

            int howmany = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if((bool) list[i])
                {
                    howmany++;
                }

            }

           switch(howmany)
            {
                case 0:break;
                case 1:passwordProgressBar.Increment(25);break;
                case 2: passwordProgressBar.Increment(25);break;
                case 3: passwordProgressBar.Increment(25);break;
                case 4: passwordProgressBar.Increment(25);break;
            }


            
            
        }
    }
}
