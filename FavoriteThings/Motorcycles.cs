using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Motorcycles
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsDirtBike { get; set; }

        public Motorcycles(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void MotoInfo()
        {
            Console.WriteLine($"A {Name} is a {Type}.");
        }

        public void OffOrOn()
        {
            if (IsDirtBike)
            {
                Console.WriteLine($"A {Name} is fun on the dirt.");
            }
            else
            {
                Console.WriteLine($"A {Name} is fun on the street.");
            }
        }
    }
}
