using System;
using System.Collections.Generic;

namespace Mod4_Self_Assessment_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();


            var Ali = new Student("Ali", "Er", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Dan = new Student("Dan", "Johnson", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Paul = new Student("Paul", "Cole", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");

            //Ali.Grades.Push(45);
            //Ali.Grades.Push(85);
            //Ali.Grades.Push(99);
            //Ali.Grades.Push(70);
            //Ali.Grades.Push(65);

            //Dan.Grades.Push(33);
            //Dan.Grades.Push(44);
            //Dan.Grades.Push(55);
            //Dan.Grades.Push(66);
            //Dan.Grades.Push(77);

            //Paul.Grades.Push(91);
            //Paul.Grades.Push(82);
            //Paul.Grades.Push(73);
            //Paul.Grades.Push(64);
            //Paul.Grades.Push(55);

            students.Add(Ali);
            students.Add(Dan);
            students.Add(Paul);

            //foreach (Student student in students)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName}");
            //}

            //Ali.Grades.Pop();
            //Dan.Grades.Pop();
            //Paul.Grades.Pop();

            //Ali.Grades.Push(77);
            //Dan.Grades.Push(76);
            //Paul.Grades.Push(99);

            Ali.Grades.Add(45, "Math");
            Ali.Grades.Add(85, "Math");
            Ali.Grades.Add(36, "Math");
            Ali.Grades.Add(73, "Geo");
            Ali.Grades.Add(56, "Geo");

            Dan.Grades.Add(67, "Math");
            Dan.Grades.Add(48, "Math");
            Dan.Grades.Add(87, "Math");
            Dan.Grades.Add(75, "Geo");
            Dan.Grades.Add(98, "Geo");

            Paul.Grades.Add(56, "Math");
            Paul.Grades.Add(85, "Math");
            Paul.Grades.Add(34, "Math");
            Paul.Grades.Add(99, "Geo");
            Paul.Grades.Add(87, "Geo");

            foreach (Student student in students)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                foreach(var grade in student.Grades){
                    Console.WriteLine($"{grade.Value} {grade.Key}");
                }
                Console.WriteLine("--------------------\n");
            }

        }
    }
}
