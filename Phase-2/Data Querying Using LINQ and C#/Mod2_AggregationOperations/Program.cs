using System;
using System.Linq;

namespace Mod2_AggregationOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] source = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            var max = source.Max();
            var min = source.Min();
            var sum = source.Sum();
            var count = source.Count();
            var longCount = source.LongCount();
            var avg = source.Average();
            var result = source
                .Aggregate((variance: 0.0, avg: source.Average(), count: source.Count()),
                (acc, e) =>
                {
                    acc.variance += Math.Pow(e - acc.avg, 2) / acc.count;
                    return acc;
                });

            Console.WriteLine($"{max.GetType().Name} {max}");
            Console.WriteLine($"{min.GetType().Name} {min}");
            Console.WriteLine($"{sum.GetType().Name} {sum}");
            Console.WriteLine($"{count.GetType().Name} {count}");
            Console.WriteLine($"{longCount.GetType().Name} {longCount}");
            Console.WriteLine($"{avg.GetType().Name} {avg}");
            Console.WriteLine($"{result.variance.GetType().Name} {result.variance}");
        }
    }
}
