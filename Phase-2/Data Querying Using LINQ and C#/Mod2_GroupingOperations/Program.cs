using System;
using System.Linq;

namespace Mod2_GroupingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = DataLoader.Load(@"./");
            var femaleTop30 = records
                .Where(r => r.Rank <= 30 && r.Gender == Gender.Female)
                .OrderBy(r => r.Name);

            // Group the name records (not name strings) into groups.
            var groups1 = femaleTop30.GroupBy(r => r.Name[0]);
            var groups2 = from r in femaleTop30 group r by r.Name[0];

            // Group the name strings by the first character of the name
            var groups3 = femaleTop30.GroupBy(r => r.Name[0], r => r.Name);
            var groups4 = from r in femaleTop30 group r.Name by r.Name[0];

            System.Console.WriteLine("----Group name records into groups----\n");
            foreach (var g in groups1)
            {
                Console.WriteLine($"Key:{g.Key} Count:{g.Count()} Names:{String.Join(",", g)}");
            }

            System.Console.WriteLine("\n----Group name strings by the first character of the name----\n");
            foreach (var g in groups3)
            {
                Console.WriteLine($"Key:{g.Key} Count:{g.Count()} Names:{String.Join(",", g)}");
            }

            System.Console.WriteLine("\n----Group name strings and put them into ValueTuple----\n");
            var result1 = femaleTop30.GroupBy(r => r.Name[0], r => r.Name)
                .Select(g => (Key: g.Key, Count: g.Count(), Names: String.Join(",", g)));

            var result2 = from r in femaleTop30
                          group r.Name by r.Name[0] into g
                          select (Key: g.Key, Count: g.Count(), Names: String.Join(",", g));

            foreach (var e in result1)
            {
                Console.WriteLine($"Key:{e.Key} Count:{e.Count} Names:{e.Names}");
            }
        }
    }
}
