using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class ProductManufacturer
    {
        String manuf;

        public ProductManufacturer()
        {

        }

        public ProductManufacturer(String manuf)
        {
            if (IsCorrect(manuf))
                this.manuf = manuf;
        }

        public string Manuf { get => manuf; set => manuf = value; }

        public bool IsCorrect(String manuf)
        {
            bool result = false;
            if (manuf == "China" || manuf == "Ukraine" || manuf == "Mexico" || manuf == "Russia" || manuf == "Philippines" 
                || manuf =="India" || manuf == "Australia" || manuf == "Canada" || manuf == "Norway")
            {
                result = true;
            }

            return result;
        }
    }
}
