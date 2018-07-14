using System;

namespace Mod2_Lab2
{
    class MainClass
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            Console.WriteLine(Days.Thu);
        }
    }
}
