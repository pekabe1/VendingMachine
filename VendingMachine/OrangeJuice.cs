using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class OrangeJuice : Drink
    {
        public OrangeJuice(drinkVolume drinkVolume, string name, decimal cost) : base(drinkVolume, name, cost)
        { 
        }
         
    }
}
