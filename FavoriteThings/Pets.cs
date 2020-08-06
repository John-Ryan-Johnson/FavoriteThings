using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Pets
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public bool IsExcited { get; set; } 
        
        
        public Pets(string name, string type)
        {
            Name = name;
            Type = type;
            
        }

        public void PetInfo()
        {
            Console.WriteLine($"{Name} is a {Age} year old {Type}.");
        }

        public void DadsHome()
        {
            if (!IsExcited)
            {
                Console.WriteLine($"{Name} must be sick when I'm not greeted at the door.");
            }
            else
            {
                Console.WriteLine($"{Name} wags whole butt when I come home.");
            }
        }

        
    }
}
