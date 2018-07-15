using System;
using System.Collections;

namespace Mod3_Self_Assessment_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList students = new ArrayList();


            var Ali = new Student("Ali", "Er", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Dan = new Student("Dan", "Johnson", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Paul = new Student("Paul", "Cole", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");

            Ali.Grades.Push(45);
            Ali.Grades.Push(85);
            Ali.Grades.Push(99);
            Ali.Grades.Push(70);
            Ali.Grades.Push(65);

            Dan.Grades.Push(33);
            Dan.Grades.Push(44);
            Dan.Grades.Push(55);
            Dan.Grades.Push(66);
            Dan.Grades.Push(77);

            Paul.Grades.Push(91);
            Paul.Grades.Push(82);
            Paul.Grades.Push(73);
            Paul.Grades.Push(64);
            Paul.Grades.Push(55);

            students.Add(Ali);
            students.Add(Dan);
            students.Add(Paul);

            foreach(Student student in students){
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

        }
    }
}
