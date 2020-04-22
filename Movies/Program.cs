using System;
using System.Collections.Generic;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {

            Movies shrek = new Movies("Shrek", "Tom Smith", "PG");
            Movies Ishq = new Movies("Titanic", "Jack Ryan", "PG-13");
            shrek.Rating = "PG-13";
            Console.WriteLine(shrek.Rating);
            Console.WriteLine(shrek.checkRating());

            List<Movies> movieList = new List<Movies>();

            movieList.Add(shrek);
            movieList.Add(Ishq);
            movieList.Add(new Movies("Two States", "Abhisek Verman", "PG-13"));
            movieList.Add(new Movies("Three Idiots", "Raju Hirani", "PG"));
            movieList.Add(new Movies("Munnabhai MBBS", "Raju Hirani", "PG-13"));

            foreach (var movie in movieList)
            {
                Console.WriteLine(movie.name);
                Console.WriteLine(movie.checkRating());
            }
	{

	}
            Console.ReadLine();
        }
    }
}
