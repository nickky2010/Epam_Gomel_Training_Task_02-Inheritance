using System;

namespace Task2.Models
{
    class PurchaseFixDiscount : AbstractPurchase
    {
        private readonly decimal discount;

        public PurchaseFixDiscount(Commodity commodity, int count, decimal discount)
            : base(commodity, count)
        {
            this.discount = discount;
        }
        public PurchaseFixDiscount()
        {
            discount = 0;
        }
        public override decimal GetCost()
        {
            decimal totalPrice = (Commodity.Price * Count);
            return (totalPrice - (totalPrice * discount));
        }

        public override string ToString()
        {
            return (base.ToString() + String.Format(";{0}", discount));
        }
    }
}