namespace Task1.Models
{
    class PurchaseUnfixDiscount : Purchase
    {
        public decimal Discount { get; private set; }
        const int countPurchaseForDiscount = 10;

        public PurchaseUnfixDiscount()
        {
            Discount = 0;
        }
        public PurchaseUnfixDiscount(string name, decimal price, int count, decimal discount)
            : base(name, price, count)
        {
            Discount = discount;
        }
        public override decimal GetCost()
        {
            if (countPurchaseForDiscount <= Count)
            {
                return (base.GetCost() - (base.GetCost() * Discount));
            }
            else
            {
                return base.GetCost();
            }
        }
        public override string ToString()
        {
            return (base.ToString() + ";" + Discount);
        }
    }
}
