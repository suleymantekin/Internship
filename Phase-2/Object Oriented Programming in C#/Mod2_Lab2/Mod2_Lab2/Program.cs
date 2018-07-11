using System;

namespace Mod2_Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Instantiates Employee Object with name Libby and salary 2000 calld employee1
            var employee1 = new TechnicalEmployee("Libby", 2000);
            var employee2 = new TechnicalEmployee("Zaynah", 75000);
            var employee3 = new BusinessEmployee("Winter", 50000);

            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "\n...\n" + employee2.employeeStatus() + "\n...\n" + employee3.employeeStatus());
        }
    }
}
