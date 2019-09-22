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



            foreach (var item in vendingMachineWarehouse.avalibleCoCaSmall)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in vendingMachineWarehouse.avalibleOrangeJuiceSmall)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in vendingMachineWarehouse.avalibleWaterSmall)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in vendingMachineWarehouse.avalibleCoCaBig)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in vendingMachineWarehouse.avalibleOrangeJuiceBig)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }
            foreach (var item in vendingMachineWarehouse.avalibleWaterBig)
            {
                Console.WriteLine($"Product Name : {item.ProdName}  | Price : {item.ProdCost} $ | Volume : {item.DrinkVolume}");
            }



            Console.WriteLine("Press 'S' if you want to buy Orane Juice");
            Console.WriteLine("Press 'W' if you want to buy Water");
            Console.WriteLine("Press 'C' if you want to buy Coca Cola");
            var selectProduct = Console.ReadKey();




            switch (selectProduct.Key)
            {
                case ConsoleKey.S: // Orane juice
                    {

                        Console.WriteLine("press again 'S' for small orange juice or 'B' for orange juice");
                        var selectedVolume = Console.ReadKey();

                        if (selectedVolume.Key == ConsoleKey.S)
                        {
                            PaymentProcessing paymentProcessing = new PaymentProcessing();
                            Console.WriteLine();
                            Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdCost}");
                            Console.WriteLine("Insert coins in nominals 1,2,5");
                            var coin = Convert.ToInt32(Console.ReadLine());
                            paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last());
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleCoCaSmall.Last()));
                            vendingMachineWarehouse.avalibleOrangeJuiceSmall.Pop();
                        }
                        else if (selectedVolume.Key == ConsoleKey.B)
                        {
                            PaymentProcessing paymentProcessing = new PaymentProcessing();
                            Console.WriteLine();
                            Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleOrangeJuiceSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleOrangeJuiceBig.Last().ProdCost}");
                            Console.WriteLine("Insert coins in nominals 1,2,5");
                            var coin = Convert.ToInt32(Console.ReadLine());
                            paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleOrangeJuiceBig.Last());
                            vendingMachineWarehouse.avalibleOrangeJuiceSmall.Pop();
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleCoCaBig.Last()));
                            vendingMachineWarehouse.avalibleOrangeJuiceBig.Pop();
                        }
                        else
                        {
                            Console.WriteLine("You pressed wrong button");
                        }
                        break;
                    }
                case ConsoleKey.W:// Water
                    {
                        Console.WriteLine("press again 'S' for small water or 'B' for big water");

                        var selectedVolume = Console.ReadKey();
                        if (selectedVolume.Key == ConsoleKey.S)
                        {
                            PaymentProcessing paymentProcessing = new PaymentProcessing();
                            Console.WriteLine();
                            Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleWaterSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleWaterSmall.Last().ProdCost}");
                            Console.WriteLine("Insert coins in nominals 1,2,5");
                            var coin = Convert.ToInt32(Console.ReadLine());
                            paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleWaterSmall.Last());

                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleWaterSmall.Last()));
                            vendingMachineWarehouse.avalibleWaterSmall.Pop();// water small
                        }
                        else if (selectedVolume.Key == ConsoleKey.B)
                        {
                            PaymentProcessing paymentProcessing = new PaymentProcessing();
                            Console.WriteLine();
                            Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleWaterBig.Last().ProdName} which cost {vendingMachineWarehouse.avalibleWaterBig.Last().ProdCost}");
                            Console.WriteLine("Insert coins in nominals 1,2,5");
                            var coin = Convert.ToInt32(Console.ReadLine());

                            paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleWaterBig.Last());
                            vendingMachineWarehouse.avalibleOrangeJuiceSmall.Pop();
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleWaterBig.Last()));
                            vendingMachineWarehouse.avalibleWaterBig.Pop();
                        }
                        else
                        {
                            Console.WriteLine("You pressed wrong button");
                        }
                        break;
                    }
                case ConsoleKey.C:// Water
                    {
                        Console.WriteLine("press again 'S' for small water or 'B' for big water");

                        var selectedVolume = Console.ReadKey();
                        if (selectedVolume.Key == ConsoleKey.S)
                        {
                            PaymentProcessing paymentProcessing = new PaymentProcessing();
                            Console.WriteLine();
                            Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdName} which cost {vendingMachineWarehouse.avalibleCoCaSmall.Last().ProdCost}");
                            Console.WriteLine("Insert coins in nominals 1,2,5");

                            var coin = Convert.ToInt32(Console.ReadLine());
                            paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleCoCaSmall.Last());

                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleCoCaSmall.Last()));
                            vendingMachineWarehouse.avalibleCoCaSmall.Pop();// water small
                        }
                        else if (selectedVolume.Key == ConsoleKey.B)
                        {
                            PaymentProcessing paymentProcessing = new PaymentProcessing();
                            Console.WriteLine();
                            Console.WriteLine($"You chose {vendingMachineWarehouse.avalibleCoCaBig.Last().ProdName} which cost {vendingMachineWarehouse.avalibleCoCaBig.Last().ProdCost}");
                            Console.WriteLine("Insert coins in nominals 1,2,5");
                            var coin = Convert.ToInt32(Console.ReadLine());
                            paymentProcessing.AddCoins(coin, vendingMachineWarehouse.avalibleCoCaBig.Last());
                            vendingMachineWarehouse.avalibleCoCaBig.Pop();
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine($"Inserted Coins {paymentProcessing.CustomerInsertedCoins} ");
                            Console.WriteLine("Change for you " + paymentProcessing.GiveChange(vendingMachineWarehouse.avalibleCoCaBig.Last()));
                            vendingMachineWarehouse.avalibleCoCaBig.Pop();
                        }
                        else
                        {
                            Console.WriteLine("You pressed wrong button");
                        }
                        break;
                    }




            }
            Console.Read();
        }
    }
}
