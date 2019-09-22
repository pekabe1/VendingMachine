using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductWarehouse _vendingMachineWarehouse = new ProductWarehouse();
           


            foreach (var item in _vendingMachineWarehouse.avalibleCoCaSmall)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in _vendingMachineWarehouse.avalibleOrangeJuiceSmall)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in _vendingMachineWarehouse.avalibleWaterSmall)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
               foreach (var item in _vendingMachineWarehouse.avalibleCoCaBig)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in _vendingMachineWarehouse.avalibleOrangeJuiceBig)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in _vendingMachineWarehouse.avalibleWaterBig)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            


            Console.WriteLine("Press 'S' if you want to buy Orane Juice");
            Console.WriteLine("Press 'W' if you want to buy Water");
            Console.WriteLine("Press 'C' if you want to buy Coca Cola");
            var selectProduct = Console.ReadKey();

            PaymentProcessing paymentProcessing;


            Console.Read();
        }
    }
}
