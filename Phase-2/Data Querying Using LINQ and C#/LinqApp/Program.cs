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

            var objects = new Object[] { 1, 10L, 1.1, 1.1f, "Hello", 2, 3 };
            var result = objects.OfType<int>();
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
