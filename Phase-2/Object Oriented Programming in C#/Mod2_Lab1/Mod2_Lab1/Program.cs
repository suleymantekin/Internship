using System;

namespace Mod2_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Instantiates Employee Object with name Libby and salary 2000 called employee1
            var employee1 = new Employee("Libby", 2000);
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee2 = new TechnicalEmployee("Zaynah", 75000);
            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee3 = new BusinessEmployee("Winter", 50000);

            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
