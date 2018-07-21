using System;
using System.Linq;

namespace Mod2_SingleElementOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# has an operator called default. 
            // The default operator can generate the default value object of the given type.

            // var dv1 = default(long); // 0L
            // int dv2 = default; // 0, syntax of C# 7.1
            // var dv3 = default(string); // null

            int[] a1 = { 0, 1, 2 };
            string[] a2 = { "Tim", "Tom", "Rina" };
            var dv1 = a1.ElementAtOrDefault(3);
            var dv2 = a2.ElementAtOrDefault(3);
            System.Console.WriteLine(dv1 == 0);
            System.Console.WriteLine(dv2 == null);


            string[] names = { "Andrew", "Tim", "Tom", "Rina" };
            var eAt3 = names.ElementAt(3);

            var head = names.First();
            var firstT = names.First(n => n.StartsWith("T"));

            var tail = names.Last();
            var lastT = names.Last(n => n.StartsWith("T"));

            var singleA = names.Single(n => n.StartsWith("A"));
            Console.WriteLine($"{eAt3}, {head}, {firstT}, {tail}, {lastT}, {singleA}");
        }
    }
}
