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
            ProductWarehouse vendingMachineWarehouse = new ProductWarehouse();


            #region


            //foreach (var item in vendingMachineWarehouse.avalibleCoCaSmall)
            //{
            //    Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            //}
            //foreach (var item in vendingMachineWarehouse.avalibleOrangeJuiceSmall)
            //{
            //    Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            //}
            //foreach (var item in vendingMachineWarehouse.avalibleWaterSmall)
            //{
            //    Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            //}
            //foreach (var item in vendingMachineWarehouse.avalibleCoCaBig)
            //{
            //    Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            //}
            //foreach (var item in vendingMachineWarehouse.avalibleOrangeJuiceBig)
            //{
            //    Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            //}
            //foreach (var item in vendingMachineWarehouse.avalibleWaterBig)
            //{
            //    Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            //}



            //Console.WriteLine("Press 'S' if you want to buy Orane Juice");
            //Console.WriteLine("Press 'W' if you want to buy Water");
            //Console.WriteLine("Press 'C' if you want to buy Coca Cola");
            //var selectProduct = Console.ReadKey();




            //switch (selectProduct.Key)
            //{
            //    case ConsoleKey.S: // Orane Juice Small
            //        {

            //            Console.WriteLine("press again 'S' for small orange juice or 'B' for orange juice");
            //            var selectedVolume = Console.ReadKey();

            //            if (selectedVolume.Key == ConsoleKey.S)
            //            {
            //                PaymentProcessing paymentProcessing = new PaymentProcessing();
            //                Console.WriteLine();
            //                Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdCost}");
            //                Console.WriteLine("Insert coins in nominals 1,2,5");
            //                var coin = Convert.ToInt32(Console.ReadLine());
            //                while (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdCost)
            //                {

            //                    paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last());
            //                    if (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdCost)
            //                    {
            //                        Console.WriteLine("Insert next coin");
            //                    }
            //                }
            //                Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
            //                Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last()));
            //                vendingMachineWarehouse.avalibleOrangeJuiceSmall.Pop();
            //            }
            //            else if (selectedVolume.Key == ConsoleKey.B)// Orange Juice Big
            //            {
            //                PaymentProcessing paymentProcessing = new PaymentProcessing();
            //                Console.WriteLine();
            //                Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleOrangeJuiceBig.Last().ProdName} which cost {vendingMachineWarehouse.avalibleOrangeJuiceBig.Last().ProdCost}");
            //                Console.WriteLine("Insert coins in nominals 1,2,5");
            //                var coin = Convert.ToInt32(Console.ReadLine());
            //                while (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleOrangeJuiceBig.Last().ProdCost)
            //                {

            //                    paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleOrangeJuiceBig.Last());
            //                    if (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleOrangeJuiceBig.Last().ProdCost)
            //                    {
            //                        Console.WriteLine("Insert next coin");
            //                    }
            //                }

            //                vendingMachineWarehouse.avalibleOrangeJuiceBig.Pop();
            //                Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");

            //                Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleOrangeJuiceBig.Last()));
            //                vendingMachineWarehouse.avalibleOrangeJuiceBig.Pop();
            //            }
            //            else
            //            {
            //                Console.WriteLine("You pressed wrong button");
            //            }
            //            break;
            //        }
            //    case ConsoleKey.W:// Water
            //        {
            //            Console.WriteLine("press again 'S' for small water or 'B' for big water");

            //            var selectedVolume = Console.ReadKey();
            //            if (selectedVolume.Key == ConsoleKey.S) // Water Small
            //            {
            //                PaymentProcessing paymentProcessing = new PaymentProcessing();
            //                Console.WriteLine();
            //                Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleWaterSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleWaterSmall.Last().ProdCost}");
            //                Console.WriteLine("Insert coins in nominals 1,2,5");
            //                var coin = Convert.ToInt32(Console.ReadLine());
            //                while (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleWaterSmall.Last().ProdCost)
            //                {

            //                    paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleWaterSmall.Last());
            //                    if (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleWaterSmall.Last().ProdCost)
            //                    {
            //                        Console.WriteLine("Insert next coin");
            //                    }
            //                }
            //                Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
            //                Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleWaterSmall.Last()));
            //                vendingMachineWarehouse.avalibleWaterSmall.Pop();
            //            }
            //            else if (selectedVolume.Key == ConsoleKey.B) //Water Big
            //            {
            //                PaymentProcessing paymentProcessing = new PaymentProcessing();
            //                Console.WriteLine();
            //                Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleWaterBig.Last().ProdName} which cost {vendingMachineWarehouse.avalibleWaterBig.Last().ProdCost}");
            //                Console.WriteLine("Insert coins in nominals 1,2,5");
            //                var coin = Convert.ToInt32(Console.ReadLine());

            //                paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleWaterBig.Last());
            //                vendingMachineWarehouse.avalibleWaterBig.Pop();
            //                Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");

            //                Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleWaterBig.Last()));
            //                vendingMachineWarehouse.avalibleWaterBig.Pop();
            //            }
            //            else
            //            {
            //                Console.WriteLine("You pressed wrong button");
            //            }
            //            break;
            //        }
            //    case ConsoleKey.C:// CoCa Small
            //        {
            //            Console.WriteLine("press again 'S' for small cola or 'B' for big cola");

            //            var selectedVolume = Console.ReadKey();
            //            if (selectedVolume.Key == ConsoleKey.S)
            //            {
            //                PaymentProcessing paymentProcessing = new PaymentProcessing();
            //                Console.WriteLine();
            //                Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdCost}");
            //                Console.WriteLine("Insert coins in nominals 1,2,5");
            //                var coin = Convert.ToInt32(Console.ReadLine());
            //                while (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdCost)
            //                {

            //                    paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleCoCaSmall.Last());
            //                    if (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdCost)
            //                    {
            //                        Console.WriteLine("Insert next coin");
            //                    }
            //                }
            //                Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
            //                Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleCoCaSmall.Last()));
            //                vendingMachineWarehouse.avalibleCoCaSmall.Pop();
            //            }
            //            else if (selectedVolume.Key == ConsoleKey.B) // Coca Big
            //            {
            //                PaymentProcessing paymentProcessing = new PaymentProcessing();
            //                Console.WriteLine();
            //                Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleCoCaBig.Last().ProdName} which cost {vendingMachineWarehouse.avalibleCoCaBig.Last().ProdCost}");
            //                Console.WriteLine("Insert coins in nominals 1,2,5");
            //                var coin = Convert.ToInt32(Console.ReadLine());
            //                while (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdCost)
            //                {

            //                    paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleCoCaSmall.Last());
            //                    if (paymentProcessing.CustomerInsertedCoins < vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdCost)
            //                    {
            //                        Console.WriteLine("Insert next coin");
            //                    }
            //                }
            //                paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleCoCaBig.Last());
            //                vendingMachineWarehouse.avalibleCoCaBig.Pop();
            //                Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");

            //                Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleCoCaBig.Last()));
            //                vendingMachineWarehouse.avalibleCoCaBig.Pop();
            //            }
            //            else
            //            {
            //                Console.WriteLine("You pressed wrong button");
            //            }
            //            break;
            //        }
            #endregion

            Console.WriteLine("  Avalible Products");
            foreach (Drink item in vendingMachineWarehouse.avalibleProducts)
            {
                Console.WriteLine($"  Name : {item.ProdName} | Volume : {item.DrinkVolume} | Cost : {item.ProdCost } ");
            }

            Console.WriteLine("\nPress 'S' if you want to buy Orane Juice \nPress 'W' if you want to buy Water \nPress 'C' if you want to buy Coca Cola");
            var selectProduct = Console.ReadKey();
            Console.WriteLine("\nType Big if you want big drink \nType Small if you want small drink");
            Console.WriteLine();
            var selectVolume = Console.ReadLine();

            GiveProduct(vendingMachineWarehouse, selectProduct, selectVolume);
            Console.WriteLine();
            Console.Read();
        }
























        private static void GiveProduct(ProductWarehouse vendingMachineWarehouse, ConsoleKeyInfo selectProduct, string selectVolume)
        {
            PaymentProcessing paymentProcessing = new PaymentProcessing();
            switch (selectProduct.Key)
            {
                case ConsoleKey.S: // Orane Juice
                    {

                        var selectedDrink = vendingMachineWarehouse.avalibleProducts.OfType<OrangeJuice>().FirstOrDefault(a => a.DrinkVolume.ToString() == selectVolume.ToString());
                        paymentProcessing.DrinksInCart.Add(selectedDrink);
                        vendingMachineWarehouse.avalibleProducts.Remove(selectedDrink);
                        Console.WriteLine(selectedDrink);
                        break;
                    }
                case ConsoleKey.W: // Water
                    {

                        var selectedDrink = vendingMachineWarehouse.avalibleProducts.OfType<Water>().FirstOrDefault(a => a.DrinkVolume.ToString() == selectVolume.ToString());
                        paymentProcessing.DrinksInCart.Add(selectedDrink);
                        vendingMachineWarehouse.avalibleProducts.Remove(selectedDrink);
                        Console.WriteLine(selectedDrink);
                        break;
                    }
                case ConsoleKey.C: // Cola
                    {

                        var selectedDrink = vendingMachineWarehouse.avalibleProducts.OfType<Water>().FirstOrDefault(a => a.DrinkVolume.ToString() == selectVolume.ToString());
                        paymentProcessing.DrinksInCart.Add(selectedDrink);
                        vendingMachineWarehouse.avalibleProducts.Remove(selectedDrink);
                        Console.WriteLine(selectedDrink);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Select product again");
                        break;
                    }

            }


            while (paymentProcessing.CustomerInsertedCoins < paymentProcessing.DrinksInCart.Last().ProdCost)
            {
                Console.WriteLine("Insert coins in nominals 1,2,5");
                Console.WriteLine();
                var coin = Convert.ToInt32(Console.ReadLine());
                if (coin.In(1, 2, 5))
                {

                    paymentProcessing.AddCoins(coin);
                }
                else
                {

                    Console.WriteLine("Wrong coin, insert coin again");
                    Console.WriteLine();
                    coin = Convert.ToInt32(Console.ReadLine());

                }
            }


            Console.WriteLine("Change for you " + (paymentProcessing.CustomerInsertedCoins - paymentProcessing.DrinksInCart.Last().ProdCost));
            Console.Read();
        }
    }
}
