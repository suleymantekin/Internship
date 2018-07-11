using System;
namespace Mod2_Self_Assesment_Lab
{
    class Student : Person
    {
        public Student(string firstName, string lastName, DateTime birthDate, string adressLine1, string adressLine2, string city, string state, string postal, string country) : base(firstName, lastName, birthDate, adressLine1,  adressLine2,  city,  state,  postal,  country)
        {
            counter++;
        }

        private static int counter = 0;



        public static int CountStudent(){
            return counter;
        }

        public void TakeTest(){
            Console.WriteLine($"{this.FirstName} {this.LastName} has taken the test.\n");
        }
    }
}
