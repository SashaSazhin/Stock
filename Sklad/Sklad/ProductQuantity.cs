using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class ProductQuantity
    {
        String quantity;

        public ProductQuantity()
        {

        }

        public ProductQuantity(String quantity)
        {
            if (IsCorrect(quantity))
                this.quantity = quantity;
        }

        public string Quantity { get => quantity; set => quantity = value; }

        public bool IsCorrect(String quantity)
        {
            bool result = false;

            if(quantity.Length<=4)
            {
                for(int i = 0;i<quantity.Length;i++)
                {
                    if(quantity[i]>= '0' && quantity[i]<='9')
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
