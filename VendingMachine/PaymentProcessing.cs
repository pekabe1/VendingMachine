using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   internal class PaymentProcessing: ProductWarehouse
    {
        


        public decimal CustomerInsertedCoins { get; set; } = 0;
         

        public decimal AddCoins(decimal coin,Product product)
        {
            do
            {
                if (coin.In(1M, 2M, 5M))
                {
                    CustomerInsertedCoins += coin;
                    TotalVendingMachineCoins.Add(coin);
                }
                else Console.WriteLine("The machine accepts only coins with a value of 1, 2, 5");

            } while (product.ProdCost >= CustomerInsertedCoins);
            return CustomerInsertedCoins;
        }
       

    }
}
