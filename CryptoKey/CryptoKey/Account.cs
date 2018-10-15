using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoKey
{
    public class Account
    {
        public string Title { get; set; }
        public string Email { get; set; }
        public string Onlineuser { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public char Priority { get; set; }
        public bool marked { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}",Title.ToUpper(),Email);
        }
    }
}
