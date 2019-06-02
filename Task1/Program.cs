using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Purchase[] purchases = new Purchase[6]
                {
                    new Purchase("Sugar", 1.52m, 10),
                    new Purchase("Tea", 4.33m, 4),
                    new PurchaseFixDiscount ("Cofe", 12m, 1, 0.1m),
                    new PurchaseFixDiscount("Milk", 1.5m, 10, 0.1m),
                    new PurchaseUnfixDiscount("Bread", 1m, 5, 0.1m),
                    new PurchaseUnfixDiscount("Ice cream", 2.5m, 10, 0.1m)
                };
                bool allPurchasesAreTheSame = true;
                decimal costMax = 0m;
                int costMaxIndex = -1;
                for (int i = 0; i < purchases.Length; i++)
                {
                    Console.WriteLine(purchases[i]);
                    if (purchases[i].GetCost() > costMax)
                    {
                        costMax = purchases[i].GetCost();
                        costMaxIndex = i;
                    }
                    if (allPurchasesAreTheSame)
                    {
                        allPurchasesAreTheSame = purchases[0].Equals(purchases[i]);
                    }
                }
                Console.WriteLine("\nPurchase with highest cost is: " + purchases[costMaxIndex]);
                Console.Write("All purchases are the same: ");
                Console.WriteLine(allPurchasesAreTheSame ? "Yes" : "No");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
