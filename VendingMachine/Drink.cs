using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Drink : Product
    {
        internal Drink(drinkVolume drinkVolume,string name,decimal cost)
        {
            DrinkVolume = drinkVolume;
            ProdName = name;
            ProdCost = cost;
            
        }

        internal enum drinkVolume
        {
            Big = 1,
            Small = 2
        }

        internal drinkVolume DrinkVolume{get;set;}
        public override string ToString()
        {
            return $"Selected product : {ProdName} | Cost : { ProdCost} | Volume : { DrinkVolume} ";
        }

    }
}
