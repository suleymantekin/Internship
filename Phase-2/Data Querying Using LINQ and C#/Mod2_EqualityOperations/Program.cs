using System;
using System.Collections.Generic;
using System.Linq;

namespace Mod2_EqualityOperations
{
    class StringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return String.Compare(x, y, true) == 0;
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 0, 1, 2, 3, 4, 5 };
            var list = new List<int> { 0, 1, 2, 3, 4, 5 };
            var set = new HashSet<int> { 0, 1, 2, 3, 3, 2, 1, 4, 5 };
            var r1 = array.SequenceEqual(list);
            var r2 = array.SequenceEqual(set);
            System.Console.WriteLine(r1);
            System.Console.WriteLine(r2);

            string[] lower = { "aaa", "bbb", "ccc" };
            string[] upper = { "AAA", "BBB", "CCC" };
            var r3 = lower.SequenceEqual(upper);
            var r4 = lower.SequenceEqual(upper, new StringEqualityComparer());
            System.Console.WriteLine(r3);
            System.Console.WriteLine(r4);
        }
    }
}
