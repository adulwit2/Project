using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Sock : Product
    {
        private string length;

        public Sock(string price, string size, string length) : base(price)
        {
            this.length = length;
        }

        public string getLength()
        {
            return length;
        }
    }
}
