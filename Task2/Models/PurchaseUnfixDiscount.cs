using System;

namespace Task2.Models
{
    class PurchaseUnfixDiscount : AbstractPurchase
    {
        private readonly decimal discount;
        const int countPurchaseForDiscount = 10;

        public PurchaseUnfixDiscount(Commodity commodity, int count, decimal discount)
            : base(commodity, count)
        {
            this.discount = discount;
        }
        public PurchaseUnfixDiscount()
        {
            discount = 0;
        }

        public override decimal GetCost()
        {
            decimal totalPrice = (Commodity.Price * Count);
            if (countPurchaseForDiscount <= Count)
            {
                return (totalPrice - (totalPrice * discount));
            }
            else
            {
                return totalPrice;
            }
        }

        public override string ToString()
        {
            return (base.ToString() + String.Format(";{0}", discount));
        }
    }
}