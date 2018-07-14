using System;

namespace Mod2_Self_Assesment_Lab5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Maximum Difference
            //Description
            //Find maximum difference between 2 elements in an integer array.You may assume the array contains no less than two elements.

            //Example

            //Input : [3, 2, 9, 5]
            //        Output: 7
            //__________________________________

            //Input : [1,1,1,1]
            //        Output: 0
            int[] array = new int[] { 3, 2, 9, 5 };
            Console.WriteLine(Difference(array));

        }

        public static int Difference(int[] a)
        {
            int max = a[0], min = a[0];
            for (int i = 0; i < a.Length; i++){
                if(a[i] > max){
                    max = a[i];
                }

                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return max - min;
        }
    }
}
