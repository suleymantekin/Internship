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

            // int[] integers = { 100, 200, 300, 400, 500 };
            // string[] strings = { "Tim", "Tom", "Rina", "Andrew" };
            // var result1 = integers.Contains(200);
            // var result2 = strings.Contains("Tim");
            // System.Console.WriteLine($"{result1} {result2}");

            //----------------------------------------------------------------------------
            // The Set Operators
            // Distinct - Keeps unique elements of the collection and removes duplicate elements
            // Intersect - Returns the set intersection, which means elements that appear in each of two collections
            // Except - Returns the set difference, which means the elements of one collection that do not appear in a second collection
            // Union - Returns the set union, which means unique elements that appear in either of two collections
            // All these four operators do not have query expression(SQL - like) keywords.

            // int[] left = { 1, 1, 2, 3, 3, 4, 4 };
            // int[] right = { 3, 4, 5, 6 };

            // var distinctResult = left.Distinct();
            // var intersectResult = left.Intersect(right);
            // var exceptResult = left.Except(right);
            // var unionResult = left.Union(right);

            // Console.WriteLine($"Distinct: {string.Join(",", distinctResult)}"); // 1, 2, 3, 4
            // Console.WriteLine($"Intersect: {string.Join(",", intersectResult)}"); // 3, 4
            // Console.WriteLine($"Except: {string.Join(",", exceptResult)}"); // 1, 2
            // Console.WriteLine($"Union: {string.Join(",", unionResult)}"); // 1, 2, 3, 4, 5, 6

            //----------------------------------------------------------------------------
            // The Concat Operator
            // Concatenation refers to the operation of appending one collection to another

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            var concatResult = array1.Concat(array2); // 1,2,3,4,5,3,4,5,6,7
            var unionResult = array1.Union(array2); // 1,2,3,4,5,6,7

            System.Console.WriteLine($"Concat: {string.Join(",", concatResult)}");
            System.Console.WriteLine($"Union: {string.Join(",", unionResult)}");
        }
    }
}
