using System;
using System.Collections.Generic;
using System.Text;

namespace Marekv2
{
    class Product
    {
        private readonly string name;
        private int mass;
        private int price;
        public string Name { get; set; }
        public int Mass 
        { 
            get { return mass; } 
            set { if (value > 0) mass = value; else Console.WriteLine("Error 404"); } }

        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, int mass)
        {
            Name = name;
            Mass = mass;
        }
        public int Price 
        {
            get { return price; }
            set { if (value > 0) price = value; else Console.WriteLine("Error 404"); }
        }
        public int GetCurrentValue()
        {
            Price = WorldMarket.GetInitialPricePerKg();
            Price = WorldMarket.GetNewPricePerKg(Price);
            int cena2 = Price * Mass;
            return cena2;
        }

    }
}
