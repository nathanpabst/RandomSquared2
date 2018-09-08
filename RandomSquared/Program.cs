using System;

namespace RandomSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            Console.WriteLine("20 random integers between 1 and 50");
            //create a list
            var Random = new Random();
            for (int ctr = 1; ctr <= 20; ctr++)
                Console.WriteLine(Random.Next(1, 51));

            //populate the list
            Console.ReadLine();
        }
    }
}
