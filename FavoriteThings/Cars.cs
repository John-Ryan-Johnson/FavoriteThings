using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsCool { get; set; }

        public Cars(string make, string model)
        {
           Make = make;
           Model = model;
        }

        public void SeeMechanic()
        {
            if (IsCool)
            {
                Console.WriteLine($"A {Make} {Model} is an awesome muscle car!");
            }
            else
            {
                Console.WriteLine($"A {Make} {Model} is perfectly fine transportation.");
            }
        }

        public void Burnout(string TypeOfRoad)
        {        
            Console.WriteLine($"In a {Make} {Model} you can do a burnout on a {TypeOfRoad} road.");
        }
    }
}
