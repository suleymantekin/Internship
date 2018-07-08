using System;

namespace Mod2_Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }


            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);
        }
    }
}
