﻿using System;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }


        public void setVisible(bool b)
        {
            this.SetVisibleCore(b);
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register(this, bl);
            
            r.setVisible(true);
            this.setVisible(false);

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bl.Login(tfUsername.Text, tfPassword.Text);
                CryptoKeyGUI window = new CryptoKeyGUI(this, bl);
                this.setVisible(false);
                window.setVisible(true);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Register"))
                {
                    MessageBox2 mb = new MessageBox2("Dieser Username/Diese Email ist noch nicht vorhanden, möchten Sie stattdessen einen neuen Account hinzufügen?", Color.FromArgb(0, 51, 204), false, false);
                    mb.setVisible(true);
                    if (mb.Ok)
                    {
                        Register r = new Register(this, bl);
                        r.setVisible(true);
                        this.setVisible(false);
                    }
                } else
                {
                    MessageBox1 mb = new MessageBox1(ex.Message, Color.FromArgb(0, 51, 204), false, false);
                    mb.setVisible(true);
                }

            }
        }

        public void ClearTF()
        {
            tfUsername.Text = "";
            tfPassword.Text = "";
        }

        private void close(object sender, MouseEventArgs e)
        {
            
            this.Dispose();
        }
    }
}
