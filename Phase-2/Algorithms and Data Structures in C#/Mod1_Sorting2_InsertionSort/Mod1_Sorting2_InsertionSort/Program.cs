using System;

namespace Mod1_Sorting2_InsertionSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 7, 8, 4, 6, 2, 1 };

            Console.WriteLine("Array before sort: 7,8,4,6,2,1");

            // Declare variable for the insertion value
            int newValue;


            for (int i = 1; i < arr.Length; i++)
            {
                // set newValue equal to the second element in the array
                // we don't start at the first element because it has no preceding value
                // which means we can't move it any further forward in the array
                newValue = arr[i];

                int j = i;

                while (j > 0 && arr[j - 1] > newValue)
                {

                    arr[j] = arr[j - 1];

                    j--;

                }

                arr[j] = newValue;

            }

            Console.Write("Array after sort: ");
            foreach (int val in arr)
            {
                Console.Write(val + ",");
            }
            Console.WriteLine();
        }
    }
}
