using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class Stock
    {
        String stocknm;

        public Stock()
        {

        }

        public Stock(String stocknm)
        {
            if (IsCorrect(stocknm))
                this.stocknm = stocknm;
        }

        public string Stocknm { get => stocknm; set => stocknm = value; }

        public bool IsCorrect(String stocknm)
        {
            bool result = false;

            if (stocknm.Length == 4)
            {
                if (stocknm == "0001" || stocknm == "0002" || stocknm == "0003" || stocknm == "0004" || stocknm == "0005" || stocknm == "0006")
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
