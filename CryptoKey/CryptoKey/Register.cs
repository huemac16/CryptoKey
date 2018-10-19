using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private bool alUpp;
        private bool alLow;
        private bool alDig;
        private bool alLen;

        public Register(Login ancestor , CryptoKeyBL bl)
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ancestor = ancestor;
            this.bl = bl;
            CultureInfo ci = CultureInfo.InstalledUICulture;
            if (ci.ThreeLetterWindowsLanguageName.Equals("DEU"))
            {
                bl.German = true;
            }
            else
            {
                label2.Text = "Username";
                label3.Text = "Password";
                label4.Text = "Password";
                label5.Text = "Register";
            }
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
            catch(Exception ex)
            {
                MessageBox1 mb = new MessageBox1(ex.Message, Color.FromArgb(0, 51, 204), false, false);
                mb.setVisible(true);
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
            string text = tfpassword.Text;
           if(!alUpp)
            {
                if(text.Any(Char.IsUpper))
                {
                    passwordProgressBar.Increment(25);
                    
                    alUpp = true;

                }
              

            }
            else
            {
                if (!text.Any(Char.IsUpper))
                {
                    passwordProgressBar.Increment(-25);

                    alUpp = false;

                }


            }


            if (!alLow)
            {
                if (text.Any(Char.IsLower))
                {
                    passwordProgressBar.Increment(25);
                    alLow = true;
                }

            }
            else
            {
                if (!text.Any(Char.IsLower))
                {
                    passwordProgressBar.Increment(-25);

                    alLow = false;

                }


            }


            if (!alDig)
            {
                if (text.Any(c => char.IsDigit(c)))
                {
                    passwordProgressBar.Increment(25);
                    alDig = true;
                }

            }
            else
            {
                if (!text.Any(c => char.IsDigit(c)))
                {
                    passwordProgressBar.Increment(-25);

                    alDig = false;

                }


            }


            if (!alLen)
            {
                if (text.Length >= 8)
                {
                    passwordProgressBar.Increment(25);
                    alLen = true;
                }
            }
            else
            {
                if (!(text.Length >= 8))
                {
                    passwordProgressBar.Increment(-25);

                    alLen = false;

                }


            }







        }

        private void hover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.Show("Großbuchstabe, Kleinbuchstabe, Ziffer, mindestens 8 Stellen lang", tfpassword);

        }
    }
}
