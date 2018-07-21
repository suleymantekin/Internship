using System;
using System.Linq;
using System.Collections.Generic;

namespace Mod2_GenerationOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generation Operations
            //Generation operation refers to creating a new collection of values. 
            // There are four standard query operators in this group. 
            // All of them don't have query expression (SQL-like) syntax:

            // Repeat - Generates a collection that contains one repeated value.
            // Range - Generates a collection that contains a sequence of numbers.
            // Empty - Returns an empty collection.
            // DefaultIfEmpty - Replaces an empty collection with a default valued singleton collection.

            // The Repeat and Range Operator
            var r1 = Enumerable.Repeat("Hello", 5);
            var r2 = Enumerable.Range(0, 10);
            var r3 = Enumerable.Range(0, 10).Select(e => Math.Pow(2, e));
            var r4 = Enumerable.Range('A', 26).Select(e => (char)e);

            System.Console.WriteLine("-----------Repeat and Range-----------");
            Console.WriteLine(String.Join(",", r1));
            Console.WriteLine(String.Join(",", r2));
            Console.WriteLine(String.Join(",", r3));
            Console.WriteLine(String.Join(",", r4));


            // The Empty Operator
            System.Console.WriteLine("-----------Empty-----------");
            var r5 = Range(0, 9);
            var r6 = Range(9, 0);

            Console.WriteLine(String.Join(",", r5));
            Console.WriteLine(String.Join(",", r6));


            // The DefaultIfEmpty Operator
            System.Console.WriteLine("-----------DefaultIfEmpty-----------");
            var defaultGift = "Programming Books";
            string[] wishlist = { "Toy Car", "Video Games", "Skateboard" };
            string[] storeInventory = { "Computer", "Candy", "Flowers" };
            var iGot = wishlist.Intersect(storeInventory).DefaultIfEmpty(defaultGift);

            foreach (var gift in iGot)
            {
                System.Console.WriteLine(gift);
            }
        }

        static IEnumerable<int> Range(int start, int end)
        {
            if (start <= end)
            {
                return Enumerable.Range(start, end - start + 1);
            }
            else
            {
                return Enumerable.Empty<int>();
            }
        }
    }
}
