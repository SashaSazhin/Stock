using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class ProductName
    {
        String name;

        public ProductName()
        {

        }

        public ProductName(String name)
        {
            if (IsCorrect(name))
                this.name = name;
        }

        public string Name { get => name; set => this.name = (this.IsCorrect(value)) ? value : ""; }


        public bool IsCorrect(String name)
        {
            bool result = false;

            if (name == "Coal" || name == "Iron" || name == "Gold" || name == "Nickel" || name == "Aluminium")
            {
                result = true;
            }

                return result;
        }
    }
}