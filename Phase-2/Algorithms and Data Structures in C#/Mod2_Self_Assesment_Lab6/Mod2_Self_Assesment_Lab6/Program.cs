using System;

namespace Mod2_Self_Assesment_Lab6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Depth of Nesting Parentheses
            //Description
            //Count the depth of nesting parentheses in a string.If a string contains unmatched parentheses, count its depth to be 0.

            //Example

            //Input : "a(())b()"
            //Output: 2
            //____________________________

            //Input : "(()1()"
            //Output: 0

            Console.WriteLine(Parentheses("(()1()"));

        }

        public static int Parentheses(string S)
        {
            int current_max = 0; 
            int max = 0;    
            int n = S.Length;

            for (int i = 0; i < n; i++)
            {
                if (S[i] == '(')
                {
                    current_max++;

                    if (current_max > max)
                        max = current_max;
                }
                else if (S[i] == ')')
                {
                    if (current_max > 0)
                        current_max--;
                    else
                        return 0;
                }
            }

            if (current_max != 0)
                return 0;

            return max;
        }
    }
}
