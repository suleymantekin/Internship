using System;

namespace Mod1_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;


            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Fourth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1932, 6, 1);


            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.WriteLine("{0} years old.", age);


            Console.WriteLine(street + ", " + city + ", " + country);

            // use string interpolation
            Console.WriteLine($"Born on {birthDate}");
        }
    }
}
