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
    public partial class SettingsGUI : Form
    {
        private Color col;
        private bool darktheme;
        private bool german;
        private CryptoKeyBL bl;

        public SettingsGUI(CryptoKeyBL bl)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            btChange.FlatAppearance.BorderSize = 0;
            this.bl = bl;
            this.col = bl.Color;
            lbusercol.BackColor = bl.Color;
            this.darktheme = bl.Theme;
            this.german = bl.German;
            if (german) rbGerman.Select();
            else rbEnglish.Select();
            if (darktheme) ThemeSelector.SelectedIndex = 1;
            else ThemeSelector.SelectedIndex = 0;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            try
            {
                bl.changeUserColor(col);
                bl.changeUserLanguage(german);
                bl.changeUserTheme(darktheme);
                this.Dispose();
            } catch(Exception ex)
            {
                MessageBox1 msg = new MessageBox1(ex.Message, bl.Color, bl.Theme, bl.German);
                msg.setVisible(true);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lbusercol.BackColor = colorDialog1.Color;
            }
        }

        private void rbGerman_CheckedChanged(object sender, EventArgs e)
        {
            german = true;
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            german = false;
        }

        private void chnageTheme(object sender, EventArgs e)
        {
            if (ThemeSelector.SelectedIndex == 0) darktheme = false;
            else darktheme = true;
        }
    }
}
