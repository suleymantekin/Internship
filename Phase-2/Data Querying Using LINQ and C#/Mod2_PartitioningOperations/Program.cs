using System;
using System.Linq;

namespace Mod2_PartitioningOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Partitioning Operations
            // There are five standard query operators in this group:

            // Skip - Skips elements up to a specified position in the source collection.
            // Take - Takes elements up to a specified position in the source collection.
            // TakeLast - Takes the specified number of elements at the tail of the source collection.
            // SkipWhile - Skips elements until an element does not satisfy the condition.
            // TakeWhile - Takes elements until an element does not satisfy the condition.

            string[] source = { "A1", "A2", "B1", "B2", "C1", "C2" };
            var r1 = source.Take(3);
            var r2 = source.Take(100);
            var r3 = source.Skip(2);
            var r4 = source.Skip(100);
            var r5 = source.Skip(2).Take(2);
            var r6 = source.TakeLast(2);
            var r7 = source.TakeLast(100);

            Console.WriteLine(String.Join(",", r1));
            Console.WriteLine(String.Join(",", r2));
            Console.WriteLine(String.Join(",", r3));
            Console.WriteLine(String.Join(",", r4));
            Console.WriteLine(String.Join(",", r5));
            Console.WriteLine(String.Join(",", r6));
            Console.WriteLine(String.Join(",", r7));

            System.Console.WriteLine("\n------While------\n");
            string[] source2 = { "A1", "B1", "C1", "A2", "B2", "C2" };
            var r8 = source2.TakeWhile(e => e.StartsWith("A"));
            var r9 = source2.TakeWhile(e => !e.StartsWith("C"));
            var r10 = source2.TakeWhile(e => e.StartsWith("C"));
            var r11 = source2.SkipWhile(e => e.StartsWith("A"));
            var r12 = source2.SkipWhile(e => !e.StartsWith("C"));
            var r13 = source2.SkipWhile(e => e.StartsWith("C"));

            Console.WriteLine(String.Join(",", r8));
            Console.WriteLine(String.Join(",", r9));
            Console.WriteLine(String.Join(",", r10));
            Console.WriteLine(String.Join(",", r11));
            Console.WriteLine(String.Join(",", r12));
            Console.WriteLine(String.Join(",", r13));
        }
    }
}
