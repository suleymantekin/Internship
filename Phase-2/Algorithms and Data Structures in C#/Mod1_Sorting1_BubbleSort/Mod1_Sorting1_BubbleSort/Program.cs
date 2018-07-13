using System;

namespace Mod1_Sorting1_BubbleSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nums = { 5, 10, 3, 2, 4 };

            Console.WriteLine("Before: 5, 10, 3, 2, 4");

            // Use this to know when to stop the sorting routine
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);


            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }

        }
    }
}
