using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Drink : Product
    {
        public Drink(drinkVolume drinkVolume,string name,decimal cost)
        {
            DrinkVolume = drinkVolume;
            ProdName = name;
            ProdCost = cost;
            
        }

        public enum drinkVolume
        {
            Big = 1,
            Small = 2
        }

        public drinkVolume DrinkVolume{get;set;}
      
    }
}
