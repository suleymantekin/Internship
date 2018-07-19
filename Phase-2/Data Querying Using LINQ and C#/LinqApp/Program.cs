using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Where Operator
            // var record = DataLoader.Load(@"./");
            // var femaleTop10 = record
            //     .Where(r => r.Gender == Gender.Female && r.Rank <= 10);
            // var maleTop10 = from r in record
            //                 where r.Gender == Gender.Male && r.Rank <= 10
            //                 select r;
            // foreach (var r in femaleTop10)
            //     System.Console.WriteLine(r);
            // foreach (var r in maleTop10)
            //     System.Console.WriteLine(r);

            //----------------------------------------------------------------------------
            // The OfType Operator

            // var objects = new Object[] { 1, 10L, 1.1, 1.1f, "Hello", 2, 3 };
            // var result = objects.OfType<int>();
            // foreach (var item in result)
            // {
            //     System.Console.WriteLine(item);
            // }

            //----------------------------------------------------------------------------
            // The All Operator
            // The All operator determines whether all the elements in a collection satisfy a condition.
            // All operators does not have query expression (SQL-like) syntax.

            // var records = DataLoader.Load(@"./");
            // var result = records.All(r => r.Name.Length > 3);
            // System.Console.WriteLine(result);

            //----------------------------------------------------------------------------
            // The Any Operator
            // Any operator determines whether there is at least one element 
            // in the source collection that satisfies the condition.
            // Any operators does not have query expression (SQL-like) syntax.

            // var records = DataLoader.Load(@"./");
            // var result = records.Any(r => r.Name.Length > 15);
            // System.Console.WriteLine(result);

            //----------------------------------------------------------------------------
            // The Contains Operator
            // The Contains operator determines whether a collection contains a specified element.
            // Any operators does not have query expression (SQL-like) syntax.


            int[] integers = { 100, 200, 300, 400, 500 };
            string[] strings = { "Tim", "Tom", "Rina", "Andrew" };
            var result1 = integers.Contains(200);
            var result2 = strings.Contains("Tim");
            System.Console.WriteLine($"{result1} {result2}");
        }
    }
}
