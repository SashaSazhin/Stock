using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class Product
    {
        String name;
        String manuf;
        String price;
        String quantity;
        String stocknm;
        String mlot;

        public Product(String name,String manuf,String price,String quantity,String stocknm,String mlot)
        {
            this.Name = name;
            this.Manuf = manuf;
            this.Price = price;
            this.Quantity = quantity;
            this.Stocknm = stocknm;
            this.Mlot = mlot;
        }

        public string Name { get => name; set => name = value; }
        public string Manuf { get => manuf; set => manuf = value; }
        public string Price { get => price; set => price = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Stocknm { get => stocknm; set => stocknm = value; }
        public string Mlot { get => mlot; set => mlot = value; }

        public String ToString()
        {

            if (name.Length < 5)
            {
                return this.name + "\t\t" + this.manuf + "\t\t" + this.price + "\t\t" + this.quantity +"\t\t" + this.stocknm + "\t\t" + this.mlot;
            }
            else if(name.Length == 6 && manuf.Length == 6)
            {
                return this.name + "\t\t" + this.manuf + "\t\t" + this.price + "\t\t" + this.quantity + "\t\t" + this.stocknm + "\t\t" + this.mlot;
            }
            else if(name.Length ==6 && manuf.Length == 11)
            {
                return this.name + "\t\t" + this.manuf + "\t" + this.price + "\t\t" + this.quantity + "\t\t" + this.stocknm + "\t\t" + this.mlot;
            }
            else
                return this.name + "\t" + this.manuf + "\t\t" + this.price + "\t\t" + this.quantity + "\t\t" + this.stocknm + "\t\t" + this.mlot;
        }

    }
}
