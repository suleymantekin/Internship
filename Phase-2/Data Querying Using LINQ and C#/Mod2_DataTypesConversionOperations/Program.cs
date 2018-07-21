using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mod2_DataTypesConversionOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList() { 100, 200, 300, 400 };
            var nums = arrayList.Cast<int>();
            System.Console.WriteLine("-----------Cast-----------");
            System.Console.WriteLine(nums is IEnumerable<int>);
            System.Console.WriteLine(String.Join(",", nums));

            System.Console.WriteLine("-----------ToList, ToArray, ToHashSet, ToDictionary and ToLookup-----------");
            var records = DataLoader.Load(@"./");
            var maleTop100 = records
                .Where(r => r.Rank <= 100 && r.Gender == Gender.Male);
            var list = maleTop100.ToList();
            var array = maleTop100.ToArray();
            var set = maleTop100.ToHashSet();
            var dict = maleTop100.ToDictionary(r => r.Name, r => r.Rank);
            var lookup = maleTop100.ToLookup(r => (r.Rank - 1) / 10, r => r.Name);

            // Check collection type
            System.Console.WriteLine(maleTop100.GetType());
            System.Console.WriteLine(list.GetType());
            System.Console.WriteLine(array.GetType());
            System.Console.WriteLine(set.GetType());
            System.Console.WriteLine(dict.GetType());
            System.Console.WriteLine(lookup.GetType());
            System.Console.WriteLine(lookup.First().GetType());

            System.Console.WriteLine("=======================");

            // Check values
            System.Console.WriteLine(dict["Timothy"]);
            System.Console.WriteLine(String.Join(",", lookup[0]));

        }
    }
}
