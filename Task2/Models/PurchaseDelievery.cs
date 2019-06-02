using System;

namespace Task2.Models
{
    class PurchaseDelievery : AbstractPurchase
    {
        private readonly decimal deliveryCost;

        public PurchaseDelievery(Commodity commodity, int count, decimal deliveryCost)
            : base(commodity, count)
        {
            this.deliveryCost = deliveryCost;
        }
        public PurchaseDelievery()
        {
            deliveryCost = 0;
        }

        public override decimal GetCost()
        {
            return ((Commodity.Price*Count) + deliveryCost);
        }

        public override string ToString()
        {
            return (base.ToString() + String.Format(";{0}", deliveryCost));
        }
    }
}