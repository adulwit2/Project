using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Band : Product
    {
        private string color;

        public Band(string price, string size, string length, string color) : base(price)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }
    }
}
