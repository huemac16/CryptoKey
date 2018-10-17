using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKey
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Screen screen = Screen.PrimaryScreen;
            int S_width = screen.Bounds.Width;
            int S_height = screen.Bounds.Height;
            Console.WriteLine("{0}x{1}" , S_width, S_height);

   


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
