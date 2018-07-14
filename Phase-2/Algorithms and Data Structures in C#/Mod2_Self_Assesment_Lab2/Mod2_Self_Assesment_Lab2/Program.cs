using System;

namespace Mod2_Self_Assesment_Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Average of a list of numbers
            //Description
            //Compute average of an integer array, rounded to closest integer or closest even integer when the fractional part is exactly .5.

            //Example

            //Input : [1,3,1,1]
            //        Output: 2
            //___________________________

            //Input : [-3,2]
            //        Output: 0
            //___________________________

            //Input : [-2,4,-1,6]
            //        Output: 2

            int[] numbers = new int[] { -2, 4, -1, 6};
            Console.WriteLine($"Average is {Average(numbers)}");
        }

        public static int Average(int[] a)
        {
            int sum = 0;
            double avr;
            foreach(int num in a){
                sum += num;
            }

            avr = (double)sum / a.Length;

            if((Math.Floor(avr) + 0.5 ) <= avr){
                return (int)Math.Ceiling(avr);
                    
            }else {
                return (int)Math.Floor(avr);
            }
        }
    }
}
