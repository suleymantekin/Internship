using System;
using System.Linq;

namespace Mod4_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameString = "Tim,Ella,Tom,Gary,Gerry,Andrew,Marwa,Bre'Ana,Li";
            var names = nameString.Split(",");
            var lookup = names.ToLookup(n => n[0], n => n);
            Console.WriteLine(string.Join(",", lookup['G']));
        }
    }
}
