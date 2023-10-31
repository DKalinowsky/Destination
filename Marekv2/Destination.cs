using System;
using System.Collections.Generic;
using System.Text;

namespace Marekv2
{
    public class Destination
    {
        private string name;
        private int distance;

        public string Name { get; set; }
        public int Distance
        { 
            get { return distance; } 
            set { if (value > 0) distance = value; else Console.WriteLine("Error 404"); } }

        public Destination(int distance, string name) 
        {
            Name = name;
            Distance = distance;

        }
    }
}
