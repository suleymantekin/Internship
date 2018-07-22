using System;
using Mod3_Lab1_WorldApp.Models;
using System.Linq;

namespace Mod3_Lab1_WorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------------------------------
            // Module 3
            // Setup

            var dbContext = new WorldContext();
            // var continents = dbContext.Continent.ToList();
            // foreach (var c in continents)
            // {
            //     System.Console.WriteLine($"ID:{c.Id} Name:{c.Name}");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The Where Operator
            // Find out the countries with a population greater than 100 million

            // var countries = dbContext.Country
            //     .Where(c => c.Population >= 100000000);
            // // var countries = from c in dbContext.Country where c.Population > 100000000 select c;
            // foreach (var c in countries)
            // {
            //     Console.WriteLine($"{c.Name} => {c.Population}");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The All Operator
            // Print whether all cities' population are greater than 1000

            // var result = dbContext.City.All(c => c.Population > 1000);
            // Console.WriteLine(result);

            //--------------------------------------------------------------------------------------------------------------------------
            // The Any Operator
            // Is there any continent data stored in the database?
            // Is there any city with a population that is greater than 10 million ?

            var r1 = dbContext.Continent.Any();
            var r2 = dbContext.City.Any(c => c.Population > 10000000);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}
