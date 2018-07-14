using System;

namespace Mod2_Self_Assesment_Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Reverse Characters
            //Description
            //Reverse all but first and last characters of a string.

            //Example

            //Input : "abcad"
            //Output: "aacbd"
            //__________________________________

            //Input : "a0b c1d"
            //Output: "a1c b0d"

            Console.WriteLine(Reversal("a0b c1d"));
        }

        public static string Reversal(string s)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 1; i <= charArray.Length / 2; i++){
                char temp = charArray[i];
                charArray[i] = charArray[charArray.Length - i - 1];
                charArray[charArray.Length - i - 1] = temp;
            }

            return new string(charArray);
        }
    }
}
