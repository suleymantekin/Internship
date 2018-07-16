using System;
using System.Collections.Generic;

namespace Mod4_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();


            var Ali = new Student("Ali", "Er", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Dan = new Student("Dan", "Johnson", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Paul = new Student("Paul", "Cole", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");

            students.Add(Ali);
            students.Add(Dan);
            students.Add(Paul);

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            students.Remove(Ali);
            Console.WriteLine($"The number of students is {students.Count}");
        }
    }
}
