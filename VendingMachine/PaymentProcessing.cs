using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class PaymentProcessing : ProductWarehouse
    {



        public decimal CustomerInsertedCoins { get; set; } = 0;


        public decimal AddCoins(decimal coin)
        {
            if (coin.In(1, 2, 5))
            {


                CustomerInsertedCoins = coin + CustomerInsertedCoins;
                TotalVendingMachineCoins.Add(CustomerInsertedCoins);
            }

            else Console.WriteLine("The machine accepts only coins with a value of 1, 2, 5");
            return CustomerInsertedCoins;
        }
        //internal decimal GiveChange(Product product)
        //{
        //    if (CustomerInsertedCoins > product.ProdCost)
        //    {
        //        return CustomerInsertedCoins - product.ProdCost;
        //    }
        //    else return 0;

        //}
        internal List<Drink> DrinksInCart { get; set; } = new List<Drink>();




    }
}
