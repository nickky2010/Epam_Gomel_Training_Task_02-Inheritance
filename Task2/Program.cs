using System;
using Task2.Models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AbstractPurchase[] abstractPurchases =
                {
                    new PurchaseFixDiscount(new Commodity("Sugar", 1.52m), 10, 0.1m),
                    new PurchaseFixDiscount(new Commodity("Tea", 4.33m),  5, 0.1m),
                    new PurchaseUnfixDiscount(new Commodity("Cofe", 12m), 1, 0.1m),
                    new PurchaseUnfixDiscount(new Commodity("Milk", 1.5m), 10, 0.1m),
                    new PurchaseDelievery(new Commodity("Bread", 1m), 100, 10m),
                    new PurchaseDelievery(new Commodity("Ice cream", 2.5m), 100, 10m)
                };
                Show(abstractPurchases);
                Array.Sort(abstractPurchases);
                Console.WriteLine("\nAfter descending sorting:");
                Show(abstractPurchases);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void Show(AbstractPurchase[] abstractPurchases)
        {
            foreach (var purchase in abstractPurchases)
            {
                Console.WriteLine(purchase);
            }
        }
    }
}
