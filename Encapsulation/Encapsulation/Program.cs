using Encapsulation.Models;
using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer singer = new Singer();
            singer.name = "Ed";
            singer.surname = "Sheeran";
            singer.age = 25;
            Console.WriteLine("Singer'name is" + " " + singer.name);
            Console.WriteLine("Singer'surname is" + " " + singer.surname);
            Console.WriteLine("Singer'age is" + " " + singer.age);


            Song song = new Song();
            song.AddRating(4);
            song.AddRating(9);
            song.AddRating(8);
            song.AddRating(3);
            song.AddRating(8);
            song.Genre = "Pop";
            Console.WriteLine("Genre of song is" + " " + song.Genre);
            Console.WriteLine(song.GetAverageRatings());
        }
    }
}
