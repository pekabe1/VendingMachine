using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class CoCaCola : Drink
    {
        public CoCaCola(drinkVolume drinkVolume, string name, decimal cost) : base(drinkVolume, name, cost)
        {
        }
    }
}
