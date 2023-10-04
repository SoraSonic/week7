using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class Product
    {
        int code, price;
        string name;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string getName()
        {
            return name;
        }
        public int getCode()
        {
            return code;
        }

        public int getPrice()
        {
            return price;
        }
        public Product( int code, string name, int price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }
    }
}
