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

            var countries = dbContext.Country
                .Where(c => c.Population >= 100000000);
            foreach (var c in countries)
            {
                Console.WriteLine($"{c.Name} => {c.Population}");
            }
        }
    }
}
