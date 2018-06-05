using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class Lot
    {
        String mlot;

        public Lot()
        {

        }

        public Lot(String mlot)
        {
            if (IsCorrect(mlot))
                this.mlot = mlot;
        }

        public string Mlot { get => mlot; set => mlot = value; }

        public bool IsCorrect(String mlot)
        {
            bool result = false;

            if (mlot == "25" || mlot == "50" || mlot == "100"|| mlot == "150" || mlot == "200")
            {
                result = true;
            }

            return result;
        }
    }
}
