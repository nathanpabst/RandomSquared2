using System;
using System.Collections.Generic;

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
            var randoNums = new List<int>();
            
            for (int i = 0; i <= 20; i++)
            {
                var results = Random.Next(1, 51);
                Console.WriteLine(results);

                Console.WriteLine("Here is that number squared:");

                randoNums.Add(results * results);
                Console.WriteLine(randoNums[i]);
            }

            //populate the list
            Console.ReadLine();
        }
    }
}
