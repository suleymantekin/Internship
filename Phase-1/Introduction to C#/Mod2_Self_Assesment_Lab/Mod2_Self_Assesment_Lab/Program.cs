using System;

namespace Mod2_Self_Assesment_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int limit = 8;
            for (int i = 0; i < limit; i++){
                for (int j = 0; j < limit; j++){
                    if((i + j) % 2 == 0 ){
                        Console.Write("X");
                    } else {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
