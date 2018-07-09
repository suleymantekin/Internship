using System;

namespace Mod3_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Sum(30, 60);

            int result = Sum(30, 10);
            Console.WriteLine($"The sum of 30 and 10 is {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
        }

        //static void Sum(int first, int second)
        //{
        //    int sum = first + second;
        //    Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        //}

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
