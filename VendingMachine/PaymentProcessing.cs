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
                
            }

            else Console.WriteLine("The machine accepts only coins with a value of 1, 2, 5");
            return CustomerInsertedCoins;
        }
        //internal decimal GiveChange(PaymentProcessing paymentProcessing, ProductWarehouse productWarehouse)
        //{


        //    decimal change = CustomerInsertedCoins - paymentProcessing.DrinksInCart.Last().ProdCost;
        //    for (int i = 0; i < productWarehouse.TotalVendingMachineCoins.Count(); i++)
        //    {
        //        if (change == productWarehouse.TotalVendingMachineCoins[i])
        //        {
        //            productWarehouse.TotalVendingMachineCoins.Remove(i);
        //            Console.WriteLine($"Returned nominals {change}");
        //            return change;

        //        }
        //        else if (change > productWarehouse.TotalVendingMachineCoins[i])
        //        {
        //       
        //}
        internal List<Drink> DrinksInCart { get; set; } = new List<Drink>();




    }
}
