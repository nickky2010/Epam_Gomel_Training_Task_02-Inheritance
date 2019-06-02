using System;

namespace Task2.Models
{
    class Commodity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Commodity()
        {
            Name = null;
            Price = 0;
        }

        public Commodity(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0};{1}", Name, Price);
        }
    }
}