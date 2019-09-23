using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class ProductWarehouse
    {
        #region
        //internal Stack<Drink> avalibleCoCaBig { get; set; } = new Stack<Drink>();
        //internal Stack<Drink> avalibleCoCaSmall { get; set; } = new Stack<Drink>();
        //internal Stack<Drink> avalibleWaterSmall { get; set; } = new Stack<Drink>();
        //internal Stack<Drink> avalibleWaterBig { get; set; } = new Stack<Drink>();
        //internal Stack<Drink> avalibleOrangeJuiceSmall { get; set; } = new Stack<Drink>();
        //internal Stack<Drink> avalibleOrangeJuiceBig { get; set; } = new Stack<Drink>();
        //internal List<decimal> TotalVendingMachineCoins { get; set; } = new List<decimal>();


        //internal ProductWarehouse()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleWaterBig.Push(new Water(Water.drinkVolume.Big, "Delicus Water", 0.70M));
        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleWaterSmall.Push(new Water(Water.drinkVolume.Small, "Delicus Water", 0.50M));

        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleOrangeJuiceBig.Push(new OrangeJuice(OrangeJuice.drinkVolume.Big, "Capi & Niesmaczne", 1.5M));

        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleOrangeJuiceSmall.Push(new OrangeJuice(OrangeJuice.drinkVolume.Small, " Extra Orange", 1M));

        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleCoCaSmall.Push(new CoCaCola(CoCaCola.drinkVolume.Small, "CaCo Cola ", 2M));

        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleCoCaSmall.Push(new CoCaCola(CoCaCola.drinkVolume.Small, "Nuca cola", 2M));

        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        avalibleCoCaBig.Push(new CoCaCola(CoCaCola.drinkVolume.Big, "Cocca cola", 2.50M));

        //    }

        //TotalVendingMachineCoins.Add(50M);

        #endregion


        internal List<Product> avalibleProducts { get; set; } = new List<Product>(); // nie wiem czy get i set jest wymagane przy tworzeniu pól typu wewnętrznego
        internal List<decimal> TotalVendingMachineCoins { get; set; } = new List<decimal>();

        public ProductWarehouse()
        {
            for (int i = 0; i < 5; i++)
            {
                avalibleProducts.Add(new Water(Water.drinkVolume.Big, "Delicus Water", 0.70M));
                avalibleProducts.Add(new Water(Water.drinkVolume.Small, "Delicus Water", 0.50M));
                avalibleProducts.Add(new CoCaCola(CoCaCola.drinkVolume.Small, "CoCa Cola", 2M));
                avalibleProducts.Add(new CoCaCola(CoCaCola.drinkVolume.Big, "CoCa Cola", 2.50M));
                avalibleProducts.Add(new OrangeJuice(OrangeJuice.drinkVolume.Big, "Capi & Śmierdzi", 1M));
                avalibleProducts.Add(new OrangeJuice(OrangeJuice.drinkVolume.Small, "Capi & Śmierdzi", 1.50M));
                
            }
        }


    }





}

