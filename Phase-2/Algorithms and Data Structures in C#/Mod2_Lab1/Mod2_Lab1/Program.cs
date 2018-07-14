using System;

namespace Mod2_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Silverado";
            myCar.Color = "Gray";
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");
            Console.WriteLine();
            myCar.Accelerate();
        }
    }

    struct Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("Vroom");
        }
    }
}
