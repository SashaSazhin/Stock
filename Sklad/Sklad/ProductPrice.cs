using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class ProductPrice
    {
        String price;

        public ProductPrice()
        {

        }

        public ProductPrice(String price)
        {
            if (IsCorrect(price))
                this.price = price;
        }

        public string Price { get => price; set => price = value; }

        public bool IsCorrect(String price)
        {
            bool result = false;

            if(price == "450000" || price == "520000" || price == "4" || price == "5" || price == "780" || price == "1200" || price == "25" || price == "100" || price == "65" )
            {
                result = true;
            }

            return result;
        }
    }
}
