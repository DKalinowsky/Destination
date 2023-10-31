using System;
using System.Collections.Generic;
using System.Text;

namespace Marekv2
{
    class Ship
    {
        private int mass;
        public Engine Engine { get; set; }
        private int Mass
        {
            get { return mass; }
            set { if (value > 0) mass = value; else Console.WriteLine("Error 404"); }
        }
        public Ship()
        {
            int Mass = 123456;
            Engine = new Engine ("v8");
        }
        public Ship(Engine Engine1, int mass1)
        {
            Engine = Engine1;
            Mass = mass1;
        }
        public bool TravelOffer(Destination name, Product p1, Product p2)
        {
            int total_income = p1.GetCurrentValue() + p2.GetCurrentValue();
            int total_cost = Engine.TravelCost(name.Distance, Mass);
            if (total_income > total_cost + 1000)
            {
                Console.WriteLine("Travel has been accpeted");
                Console.WriteLine("Main destintion is " + name.Name);
                Console.WriteLine("Transporting: ");
                Console.WriteLine(p1.Name + " " + p1.Mass + " tons");
                Console.WriteLine(p2.Name + " " + p2.Mass + " tons");
                Console.WriteLine("Travel Time: " + Engine.TravelTime(name.Distance, Mass) + " hours");
                Console.WriteLine("Total cost of travel: " + total_cost + "$");
                Console.WriteLine("Total income from sale: " + total_income + "$");
                Console.WriteLine("Total profit: " + (total_income - total_cost + "$"));
                Console.WriteLine();

                return true;
            }
            else
            {
                Console.WriteLine("Travvel has been rejected");
                Console.WriteLine("Travel is not profitable.");
                Console.WriteLine();
                return false;
            }

        }
    }
}
