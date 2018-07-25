using System;
using System.Linq;

namespace Mod4_PLinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query1 = source
                .Where(n => n % 2 == 1).Select(n => -n);
            var query2 = source.AsParallel()
                .Where(n => n % 2 == 1).Select(n => -n);

            Console.WriteLine(string.Join(", ", query1));
            Console.WriteLine(string.Join(", ", query2));
        }
    }
}
