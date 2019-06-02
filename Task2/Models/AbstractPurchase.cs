using System;

namespace Task2.Models
{
    abstract class AbstractPurchase:IComparable<AbstractPurchase>
    {
        private Commodity commodity;
        private int count;

        public AbstractPurchase()
        {
        }

        public AbstractPurchase(Commodity commodity, int count)
        {
            Commodity = commodity;
            Count = count;
        }

        public Commodity Commodity
        {
            get { return commodity; }
            private set
            {
                if (value != null)
                    commodity = value;
                else
                    throw new Exception("Commodity can not be equal null");
            }
        }

        public int Count
        {
            get { return count; }
            private set
            {
                if (value >= 0)
                    count = value;
                else
                    throw new Exception("Quantity can not be less than 0");
            }
        }

        public abstract decimal GetCost();

        public override string ToString()
        {
            return String.Format("{0};{1};{2}", commodity, count, GetCost().ToString("f2"));
        }

        public int CompareTo(AbstractPurchase purchase)
        {
            if (GetCost()>purchase.GetCost())
                return -1;
            if (GetCost() < purchase.GetCost())
                return 1;
            return 0;
        }
    }
}