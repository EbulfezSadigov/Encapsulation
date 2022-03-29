using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulation.Models
{
    class Song
    {
        private string _Name;
        private string _Genre;
        private Singer _Singer;
        private int[] Ratings = new int[0];
        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                if (value == "Pop" || value == "Jazz" || value == "Techno" || value == "Rock")
                {
                    _Genre = value;
                }
            }
        }
        public string name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 100)
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("Name invalid");
                }
            }
        }
        public double GetAverageRatings()
        {
            return Ratings.Average();
        }
        public void AddRating(int rating)
        {
            if (rating > 0 && rating < 10)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }
    }
}
