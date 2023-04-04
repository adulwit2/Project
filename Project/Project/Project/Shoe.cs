using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Shoe : Product
    {
        private string size;

        public Shoe(string price, string size) : base(price)
        {
            this.size = size;
        }

        public string getSize()
        {
            return size;
        }
    }
}
