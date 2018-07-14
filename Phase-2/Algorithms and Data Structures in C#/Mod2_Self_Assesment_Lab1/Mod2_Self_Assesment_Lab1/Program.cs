using System;

namespace Mod2_Self_Assesment_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student ali = new Student();
            ali.FirstName = "Ali";
            ali.LastName = "Tekin";
            ali.Age = 18;
            Student[] students = new Student[5];
            students[0] = ali;


            Teacher Dan = new Teacher();
            Dan.FirstName = "Dan";
            Dan.LastName = "Johnson";
            Dan.Age = 55;

            Console.WriteLine($"Student 1 first name: {students[0].FirstName}\n");
            Console.WriteLine($"Student 1 last name: {students[0].LastName}\n");
            Console.WriteLine($"Student 1 age: {students[0].Age}\n");

            students[0].Study();
            Dan.GradeAssignment();


            for (int i = 1; i < students.Length; i++){
                students[i].FirstName = "Paul";
                students[i].LastName = "Boo";
                students[i].Age = 44;
            }


            foreach(Student student in students){
                Console.WriteLine($"First name: {student.FirstName}\n");
                Console.WriteLine($"Last name: {student.LastName}\n");
                Console.WriteLine($"Age: {student.Age}\n");
            }
        }
    }

    struct Student
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Study()
        {
            Console.WriteLine($"{FirstName} is studying.\n");
        }
    }


    struct Teacher
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void GradeAssignment()
        {
            Console.WriteLine($"{FirstName} is grading the assignments.\n");
        }
    }
}
