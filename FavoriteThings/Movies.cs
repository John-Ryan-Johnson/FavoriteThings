using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Movies
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public Movies(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public void Unwatched()
        {
            Console.WriteLine($"I need to see the movie {Name}");
        }

        public void Watched()
        {
            Console.WriteLine($"I have seen the movie {Name}. I think it is a {Genre} movie.");
        }
    }
}
