﻿using System;
using System.Collections.Generic;
using Mod3_Lab1_WorldApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

            // var r1 = dbContext.Continent.Any();
            // var r2 = dbContext.City.Any(c => c.Population > 10000000);
            // Console.WriteLine(r1);
            // Console.WriteLine(r2);

            //--------------------------------------------------------------------------------------------------------------------------
            // The Contains Operator
            // Find out whether a given city is in the database

            // var seattle = new City { Name = "Seattle", District = "Washington" };
            // var result = dbContext.City.ToList()
            //     .Contains(seattle, new CityEqualityComparer());
            // System.Console.WriteLine(result);

            //--------------------------------------------------------------------------------------------------------------------------
            // Include Extension Method

            // var continents = dbContext.Continent
            //     .Include(nameof(Continent.Country));
            // foreach (var c in continents)
            // {
            //     Console.WriteLine($"{c.Name.PadRight(16)} {c.Country.Count}");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The Select Operator
            // Could you list the name of countries with a population greater than 1 billion?

            // var names = dbContext.Country
            //       .Where(c => c.Population > 100000000)
            //       .Select(c => c.Name);
            // foreach (var n in names)
            // {
            //     System.Console.WriteLine(n);
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The SelectMany Operator
            // Could you list the name of counties in North America and South America?

            // var names = dbContext.Continent
            //       .Include(nameof(Continent.Country))
            //       .Where(c => c.Name == "North America" || c.Name == "South America")
            //       .SelectMany(c => c.Country).Select(c => c.Name);

            // foreach (var n in names)
            // {
            //     System.Console.WriteLine(n);
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The Intersect, Except, and Union Operator
            // Countries that either have a large surface area or have a large population.
            // Countries that have both large area and large population.
            // Countries that have a large area but not a large population.

            // var bigArea = dbContext.Country
            //     .OrderByDescending(c => c.SurfaceArea).Take(10);
            // var bigPopulation = dbContext.Country
            //     .OrderByDescending(c => c.Population).Take(10);

            // var r1 = bigArea.Union(bigPopulation);
            // var r2 = bigArea.Intersect(bigPopulation);
            // var r3 = bigArea.Except(bigPopulation);

            // Console.WriteLine("[Big Area or Big Population]");
            // foreach (var r in r1)
            // {
            //     Console.WriteLine(r.Name);
            // }

            // Console.WriteLine("========================");
            // Console.WriteLine("[Big Area and Big Population]");
            // foreach (var r in r2)
            // {
            //     Console.WriteLine(r.Name);
            // }

            // Console.WriteLine("========================");
            // Console.WriteLine("[Big Area but Not Big Population]");
            // foreach (var r in r3)
            // {
            //     Console.WriteLine(r.Name);
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The Distinct Operator
            // Could you find out the continents that have countries in them? I do not think there are any countries in Antarctica, lets see if this is true.

            // var continents = dbContext.Country
            //       .Include(nameof(Country.Continent))
            //       .Select(c => c.Continent).Distinct();
            // foreach (var c in continents)
            // {
            //     System.Console.WriteLine(c.Name);
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The OrderBy and ThenByDescending Operator
            // Could you sort all counties by its continent, and then sort the counties in the same continent by population in the descending order?

            var countries = dbContext.Country
            .Include(nameof(Country.Continent))
            .OrderBy(c => c.Continent.Name)
            .ThenByDescending(c => c.Population);
            // var countries =
            //     from c in dbContext.Country.Include(nameof(Country.Continent))
            //     orderby c.Continent.Name, c.Population descending
            //     select c;

            foreach (var c in countries)
            {
                Console.WriteLine($"{c.Continent.Name} {c.Name} {c.Population}");
            }
        }
    }

    class CityEqualityComparer : IEqualityComparer<City>
    {
        public bool Equals(City x, City y)
        {
            return x.Name == y.Name && x.District == y.District;
        }

        public int GetHashCode(City obj)
        {
            return obj.GetHashCode();
        }
    }
}
