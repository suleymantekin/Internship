﻿using System;
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

            // int[] array1 = { 1, 2, 3, 4, 5 };
            // int[] array2 = { 3, 4, 5, 6, 7 };

            // var concatResult = array1.Concat(array2); // 1,2,3,4,5,3,4,5,6,7
            // var unionResult = array1.Union(array2); // 1,2,3,4,5,6,7

            // System.Console.WriteLine($"Concat: {string.Join(",", concatResult)}");
            // System.Console.WriteLine($"Union: {string.Join(",", unionResult)}");

            //----------------------------------------------------------------------------
            // The OrderBy Operator
            // Sorts values in ascending order

            // var records = DataLoader.Load(@"./");
            // var sortedByRank = records.OrderBy(r => r.Rank);
            // // The corresponding query expression (SQL-like) syntax
            // // var sortedByRank = from r in records orderby r.Rank select r;
            // foreach (var r in sortedByRank)
            // {
            //     System.Console.WriteLine(r.ToString());
            // }

            //----------------------------------------------------------------------------
            // The OrderByDescending Operator
            // Sorts values in descending order

            // var records = DataLoader.Load(@"./");
            // var sortedByRank = records.OrderByDescending(r => r.Rank);
            // // The corresponding query expression (SQL-like) syntax
            // // var sortedByRank = from r in records orderby r.Rank descending select r;
            // foreach (var r in sortedByRank)
            // {
            //     System.Console.WriteLine(r.ToString());
            // }

            /*
                Note:
                Some of the .NET built-in collections has their own Sort and Reverse member methods. 
                The difference between the member methods and the LINQ methods is the member methods 
                will perform the sorting on the collection, thus the element sequence of the collection 
                will be physically changed. While the LINQ method will generate a new result collection
                which is sorted, the source collection keeps its original element sequence.
             */

            //----------------------------------------------------------------------------
            // The ThenBy Operator
            // Performs a secondary sort in ascending order.

            // var records = DataLoader.Load(@"./");
            // var sortedByRank = records.OrderBy(r => r.Rank).ThenBy(r => r.Name);
            // // The corresponding query expression (SQL-like) syntax
            // // var sortedByRank = from r in records orderby r.Rank, r.Name select r;
            // foreach (var r in sortedByRank)
            // {
            //     System.Console.WriteLine(r.ToString());
            // }

            //----------------------------------------------------------------------------
            // The ThenByDescending operator
            // Performs a secondary sort in descending order

            // var records = DataLoader.Load(@"./");
            // var sortedByRank = records.OrderBy(r => r.Rank).ThenByDescending(r => r.Name);
            // // The corresponding query expression (SQL-like) syntax
            // // var sortedByRank = from r in records orderby r.Rank, r.Name descending select r;
            // foreach (var r in sortedByRank)
            // {
            //     System.Console.WriteLine(r.ToString());
            // }

            //----------------------------------------------------------------------------
            // The Reverse Operator
            // Reverses the order of the elements in a collection

            // int[] original = { 1979, 10, 31, 8, 15 };
            // var reversed = original.Reverse();
            // System.Console.WriteLine($"Original: {string.Join(",", original)}");
            // System.Console.WriteLine($"Reversed: {string.Join(",", reversed)}");

            //----------------------------------------------------------------------------
            // The Select Operator
            // Projects values that are based on a transform function.

            // var records = DataLoader.Load(@"./");
            // // var names = records.Select(r => r.Name);
            // // Using the query expression (SQL-like) syntax, the code will be:
            // // var names = from r in records select r.Name;

            // // Select Multiple Element Property Values
            // var items = records.Select(r => new { Rank = r.Rank, Name = r.Name });
            // // Using the query expression (SQL-like) syntax, the code will be:
            // // var items = from r in records select new { Rank = r.Rank, Name = r.Name };
            // foreach (var n in items)
            // {
            //     System.Console.WriteLine(n);
            // }

            // When using ValueTuple, the code will be:
            // var records = DataLoader.Load(@"./");
            // var items = records.Select(r => (r.Rank, r.Name));
            // // query expression (SQL-like) syntax version of this code is:
            // // var items = from r in records select (r.Rank, r.Name);
            // foreach (var item in items)
            // {
            //     // System.Console.WriteLine(item.GetType());
            //     System.Console.WriteLine($"Rank:{item.Rank} Name:{item.Name}");
            // }

            //----------------------------------------------------------------------------
            // The SelectMany Operator
            // Projects sequences of values that are based on a transform function and then flattens them into one sequence.

            // Prepare the data
            var records = DataLoader.Load(@"./");
            var dict = new Dictionary<string, IEnumerable<Record>>();
            dict["FemaleTop5"] = records.Where(r => r.Rank <= 5 && r.Gender == Gender.Female);
            dict["MaleTop5"] = records.Where(r => r.Rank <= 5 && r.Gender == Gender.Male);

            // Solution 1:
            var names1 = new List<string>();
            var selectResult = dict.Select(kvp => kvp.Value);
            foreach (var c in selectResult)
            {
                foreach (var r in c)
                {
                    names1.Add(r.Name);
                }
            }

            // Solution 2:
            var names2 = new List<string>();
            var selectManyResult = dict.SelectMany(kvp => kvp.Value);
            foreach (var r in selectManyResult)
            {
                names2.Add(r.Name);
            }

            // Solution 3:
            var names3 =
                from kvp in dict
                from r in kvp.Value
                select r.Name;



        }
    }
}
