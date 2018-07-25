using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mod4_PLinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // var query1 = source
            //     .Where(n => n % 2 == 1).Select(n => -n);
            // var query2 = source.AsParallel()
            //     .Where(n => n % 2 == 1).Select(n => -n);

            // Console.WriteLine(string.Join(", ", query1));
            // Console.WriteLine(string.Join(", ", query2));


            //-----------------------------------------------------------------------
            // Order Preservation in PLINQ

            // int[] source = Enumerable.Range(0, 20).ToArray();
            // var query1 = source.AsParallel().AsOrdered()
            //     .Where(n => n % 2 == 1).Select(n => -n);
            // var query2 = source.AsParallel().AsOrdered()
            //     .Where(n => n % 2 == 1).AsUnordered().Select(n => -n);

            // Console.WriteLine(string.Join(", ", query1));
            // Console.WriteLine(string.Join(", ", query2));

            //-----------------------------------------------------------------------
            // How to parallel the foreach loop? There are two ways:

            // Using Task-Based Parallel Library(TPL)
            // Using PLINQ

            // var source = Enumerable.Range(0, 20).ToList();

            // // TPL version
            // Parallel.ForEach(source, (item) =>
            // {
            //     Console.Write($"{item.ToString().PadLeft(2, '0')}|");
            // });

            // Console.WriteLine();
            // Console.WriteLine("======================");

            // // PLINQ version
            // source.AsParallel().ForAll((item) =>
            // {
            //     Console.Write($"{item.ToString().PadLeft(2, '0')}|");
            // });

            //-----------------------------------------------------------------------
            // Exception handling in PLinq

            var source = Enumerable.Range(0, 20).ToList();
            try
            {
                var result = source.AsParallel().Select(n => 10 / n).ToList();
                foreach (var item in result)
                {
                    Console.Write($"{item}|");
                }
            }
            catch (AggregateException e)
            {
                foreach (var item in e.InnerExceptions)
                {
                    if (item is DivideByZeroException)
                    {
                        Console.WriteLine("Zero cannot be a divisor.");
                    } // test for other exceptions
                }
            }
        }
    }
}
