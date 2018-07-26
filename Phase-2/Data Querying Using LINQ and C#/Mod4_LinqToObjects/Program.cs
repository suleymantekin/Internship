using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Mod4_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Splitting a String

            var nameString = "Tim,Ella,Tom,Gary,Gerry,Andrew,Marwa,Bre'Ana,Li";
            var names = nameString.Split(",");
            var lookup = names.ToLookup(n => n[0], n => n);
            Console.WriteLine(string.Join(",", lookup['G']));

            // String as Character Collection

            var result = from c in nameString
                         group c by Char.ToUpper(c) into g
                         orderby g.Key
                         select new { Char = g.Key, Count = g.Count() };

            foreach (var item in result)
            {
                if (item.Char < 'A' || item.Char > 'Z') continue;
                Console.WriteLine($"{item.Char}: {item.Count}");
            }

            // LINQ to Text File

            var lines = File.ReadAllLines(@"./");
            var names2 = lines.Select(l => l.Split(",")[1]);
            var result2 = from n in names
                          group n by n[0] into g
                          orderby g.Key
                          select $"{g.Key},{g.Count()}";
            File.WriteAllLines(@"./count.csv", result2);

            var reader = new StreamReader(File.OpenRead(@"./male.csv"));
            var writer = new StreamWriter(File.OpenWrite(@"./count.csv"));
            var dict = new Dictionary<char, int>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var name = line.Split(",")[1];
                if (!dict.ContainsKey(name[0]))
                {
                    dict[name[0]] = 0;
                }
                dict[name[0]]++;
            }

            var kvps = dict.OrderBy(kvp => kvp.Key);
            foreach (var kvp in kvps)
            {
                writer.WriteLine($"{kvp.Key},{kvp.Value}");
            }

            writer.Flush();
            writer.Close();
        }
    }
}
