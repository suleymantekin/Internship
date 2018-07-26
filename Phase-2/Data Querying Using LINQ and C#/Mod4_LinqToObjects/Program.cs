using System;
using System.Linq;

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
        }
    }
}
