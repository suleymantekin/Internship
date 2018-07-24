using System;
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

            // var countries = dbContext.Country
            // .Include(nameof(Country.Continent))
            // .OrderBy(c => c.Continent.Name)
            // .ThenByDescending(c => c.Population);
            // // var countries =
            // //     from c in dbContext.Country.Include(nameof(Country.Continent))
            // //     orderby c.Continent.Name, c.Population descending
            // //     select c;

            // foreach (var c in countries)
            // {
            //     Console.WriteLine($"{c.Continent.Name} {c.Name} {c.Population}");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The First, Last, and ElementAt Operator
            // Could you find out the country that has:
            // the largest surface area
            // the smallest surface area
            // the third largest surface area

            // var sorted = dbContext.Country.OrderByDescending(c => c.SurfaceArea).ToList();
            // var largest = sorted.First();
            // var thirdLarget = sorted.ElementAt(2);
            // var smallest = sorted.Last();

            // Console.WriteLine($"Largest: {largest.Name} {largest.SurfaceArea}");
            // Console.WriteLine($"Third: {thirdLarget.Name} {thirdLarget.SurfaceArea}");
            // Console.WriteLine($"Smallest: {smallest.Name} {smallest.SurfaceArea}");

            //--------------------------------------------------------------------------------------------------------------------------
            // The Single and SingleOrDefault Operator
            // Could you find out whether there is a city called: Seattle Kirkland Clara

            // try
            // {
            //     var seattle = dbContext.City.Single(c => c.Name == "Seattle");
            //     Console.WriteLine($"There is a city called Seattle.");
            // }
            // catch
            // {
            //     Console.WriteLine($"There maybe zero or more than one Seattle.");
            // }

            // try
            // {
            //     var foundOneKirkland = dbContext.City.Single(c => c.Name == "Kirkland");
            //     Console.WriteLine($"There is a city called Kirkland.");
            // }
            // catch
            // {
            //     Console.WriteLine($"There maybe zero or more than one Kirkland.");
            // }

            // try
            // {
            //     var foundOneSantaClara = dbContext.City.Single(c => c.Name == "Santa Clara");
            //     Console.WriteLine($"There is a city called Santa Clara.");
            // }
            // catch
            // {
            //     Console.WriteLine($"There maybe zero or more than one Santa Clara.");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The Skip and Take Operator
            // Given the countries sorted by their surface area in a descending order, could you find out the:
            // largest five countries
            // countries in the 21st to 25th place
            // smallest five countries

            // var sorted = dbContext.Country.OrderByDescending(c => c.SurfaceArea);
            // var largest5 = sorted.Take(5);
            // var the21to25 = sorted.Skip(20).Take(5);
            // var smallest5 = sorted.ToList().TakeLast(5);

            // Console.WriteLine("[Largest 5]");
            // foreach (var c in largest5)
            // {
            //     Console.WriteLine($"{c.Name} {c.SurfaceArea}");
            // }

            // Console.WriteLine("===================");
            // Console.WriteLine("[Largest 21 to 25]");
            // foreach (var c in the21to25)
            // {
            //     Console.WriteLine($"{c.Name} {c.SurfaceArea}");
            // }

            // Console.WriteLine("===================");
            // Console.WriteLine("[Smallest 5]");
            // foreach (var c in smallest5)
            // {
            //     Console.WriteLine($"{c.Name} {c.SurfaceArea}");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The ToArray, ToList, ToDictionary, and ToLookup Operator
            // Retrieve all continents and store them in an array?
            // Retrieve all continents and store them in a list?
            // Generate a dictionary for looking up the population of countries ?
            // Generate a Lookup < K, V > object for looking up country names by continent name ?

            // var array = dbContext.Continent.ToArray();
            // var list = dbContext.Continent.ToList();
            // var dict = dbContext.Country.ToDictionary(c => c.Name, c => c.Population);
            // var lookup = dbContext.Country.Include(nameof(Country.Continent))
            //     .ToLookup(c => c.Continent.Name, c => c.Name);

            // Console.WriteLine(array.Length);
            // Console.WriteLine(list.Count);
            // Console.WriteLine(dict["China"]);
            // Console.WriteLine(string.Join(",", lookup["Antarctica"]));

            //--------------------------------------------------------------------------------------------------------------------------
            // The Max, Min, Count and Sum Operator
            // Find the largest country area in Europe
            // the smallest country area in Europe
            // how many counties in Europe
            // the total population in Europe

            // var countries = dbContext.Country
            //     .Include(nameof(Country.Continent))
            //     .Where(c => c.Continent.Name == "Europe");

            // var largest = countries.Max(c => c.SurfaceArea);
            // var smallest = countries.Min(c => c.SurfaceArea);
            // var count = countries.Count();
            // var totalPopulation = countries.Sum(c => c.Population);

            // Console.WriteLine($"Europe Largest Country Area: {largest}");
            // Console.WriteLine($"Europe Smallest Country Area: {smallest}");
            // Console.WriteLine($"Europe Country Count: {count}");
            // Console.WriteLine($"Europe Total Population: {totalPopulation}");

            //--------------------------------------------------------------------------------------------------------------------------
            // The GroupBy Operator
            // Could you find the top 3 largest countries of each continent?

            // var countries = dbContext.Country
            //     .Include(nameof(Country.Continent))
            //     .OrderByDescending(c => c.SurfaceArea);

            // var result = countries.GroupBy(c => c.Continent.Name, c => c.Name)
            //     .Select(g => $"{g.Key}: {string.Join(",", g.Take(3))}");
            //// var result = from c in countries
            ////              group c.Name by c.Continent.Name into g
            ////              select $"{g.Key}: {string.Join(",", g.Take(3))}";

            // foreach (var r in result)
            // {
            //     Console.WriteLine(r);
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The Join Operator


            // var continents = dbContext.Continent.OrderBy(c => c.Name);
            // var countries = dbContext.Country.OrderBy(c => c.Name);

            // var result = continents.Join(countries,
            // c => c.Id, c => c.ContinentId,
            // (ctn, ctry) => new { Continent = ctn.Name, Country = ctry.Name });
            // // var result = from ctn in continents
            // //              join ctry in countries
            // //              on ctn.Id equals ctry.ContinentId
            // //              select new { Continent = ctn.Name, Country = ctry.Name };

            // foreach (var r in result)
            // {
            //     Console.WriteLine($"{r.Continent}\t {r.Country}");
            // }

            //--------------------------------------------------------------------------------------------------------------------------
            // The GroupJoin Operator

            var continents = dbContext.Continent.OrderBy(c => c.Name);
            var countries = dbContext.Country.OrderBy(c => c.Name);

            var result = continents.GroupJoin(countries,
                ctn => ctn.Id, ctry => ctry.ContinentId,
                (ctn, g) => new { Continent = ctn.Name, CountryCount = g.Count() }
            );

            // var result = from ctn in continents
            //              join ctry in countries
            //              on ctn.Id equals ctry.ContinentId into g
            //              select new { Continent = ctn.Name, CountryCount = g.Count() };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Continent}: {item.CountryCount}");
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
