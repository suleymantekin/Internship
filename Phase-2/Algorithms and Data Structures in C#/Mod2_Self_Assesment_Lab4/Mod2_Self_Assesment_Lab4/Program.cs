using System;

namespace Mod2_Self_Assesment_Lab4
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            //K - th Smallest
            //Description
            //Find k-th smallest element in an integer array.You may assume the k - th smallest value exists in the array.

            //Example

            //Input : [2, 1, 4]
            //        and k = 3
            //Output: 4
            //_____________________________

            //Input : [7, 2, 1, 6, 1]
            //        and k = 3
            //Output: 6
            int[] array = new int[] { 7, 2, 1, 6, 1 };
            Console.WriteLine(Ksmallest(array, 3));
        }

        public static int Ksmallest(int[] a, int k)
        {
            Array.Sort(a);
            var list = new System.Collections.ArrayList();

            foreach (int num in a)
            {
                if (!list.Contains(num))
                    list.Add(num);
            }

            return (int)list[k - 1];
        }
    }
}
