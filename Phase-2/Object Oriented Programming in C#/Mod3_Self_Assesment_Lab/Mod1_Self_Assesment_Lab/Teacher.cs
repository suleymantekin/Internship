using System;
namespace Mod3_Self_Assesment_Lab
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime birthDate, string adressLine1, string adressLine2, string city, string state, string postal, string country) : base(firstName, lastName, birthDate, adressLine1, adressLine2, city, state, postal, country)
        {
            counter++;
        }

        private static int counter = 0;



        public static int CountTeacher(){
            return counter;
        }

        public void GradeTest()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} grade the test.\n");
        }
    }
}
