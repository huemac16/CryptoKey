using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoKey
{
    public class Crypto
    {
        private Random rand = new Random();
        public String encrypt(String s)
        {
            int tmp = 0;
            for(int i = 0; i < s.Length; i++)
            {
                tmp = i;
                s.Insert(tmp + 1, "" + rand.Next(0, 9));
                tmp = i++;
                
            }

            return "";
        }

        public String decrypt(String s)
        {

            return "";
        }
    }
}
