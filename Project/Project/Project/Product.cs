using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Product
    {
        private string price;

        public Product(string price)
        {
            this.price = price;
        }
        public string getPrice()
        {
            return price;
        }

    }
}
