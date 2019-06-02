namespace Task1.Models
{
    class PurchaseFixDiscount: Purchase
    {
        public decimal Discount { get; private set; }
        public PurchaseFixDiscount()
        {
            Discount = 0;
        }
        public PurchaseFixDiscount(string name, decimal price, int count, decimal discount) 
            : base(name, price, count)
        {
            Discount = discount;
        }
        public override decimal GetCost()
        {
            return (base.GetCost()-(base.GetCost() * Discount));
        }
        public override string ToString()
        {
            return (base.ToString()+";"+ Discount);
        }
    }
}
