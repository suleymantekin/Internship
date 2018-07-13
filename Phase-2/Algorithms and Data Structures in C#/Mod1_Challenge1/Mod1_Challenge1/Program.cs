using System;

namespace Mod1_Challenge1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Plain English
            //Get base number
            //Get exponent
            //Set result = 1
            //While exponent is greater than 0
            //    set result = to result multiplied by base number
            //    subtract one from exponent value
            //Write out result


            //Programming language style
            //SET base to number provided
            //SET exponent to number provided
            //SET result = 1
            //WHILE exponent > 0
            //    result = result * base
            //    exponent = exponent - 1
            //OUTPUT result

            Console.WriteLine("Enter the base number: ");
            int numBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exponent number: ");
            int exp = Convert.ToInt32(Console.ReadLine().ToString());
            int result = 1;

            while (exp > 0)
            {
                result = result * numBase;
                exp--;
            }

            Console.WriteLine($"Result is {result}");


            //Plain English
            //Get radios
            //Get height
            //Set PI = 3.14
            //Set result = PI multiplied by radios multiplied by radios multiplied by height
            //Write out result


            //Programming language style
            //SET radios to number provided
            //SET height to number provided
            //SET PI = 3.14
            //Set result = PI * radios * radios * heigh
            //OUTPUT result

            Console.WriteLine("\nEnter the radios ");
            int radios = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine().ToString());
            double PI = 3.14;
            double result2 = PI * radios * radios * height;
            Console.WriteLine($"\nResult is {result2}");
        }
    }
}
