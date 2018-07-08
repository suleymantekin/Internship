using System;

namespace Mod1_Self_Assesment_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Student Information
            Console.WriteLine("Enter student name");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter student last name");
            string studentLastName = Console.ReadLine();
            DateTime studentBirthDate;
            string studentAdressLine1 = "";
            string studentAdressLine2 = "";
            string studentCity = "";
            string studentState = "";
            string studentPostal = "";
            string studentCountry = "";

            // Teacher Information
            string teacherFirstName = "Paul";
            string teacherLastName = "Cole";
            DateTime teacherBirthDate = new DateTime(1995, 3, 8);
            string teacherAdressLine1 = "12341 Black Street";
            string teacherAdressLine2 = "Green Avenue";
            string teacherCity = "Northdown";
            string teacherState = "Seattle";
            string teacherPostal = "SCV234";
            string teacherCountry = "USA";

            //UProgram Information
            string programName = "Engineering";
            string departmentHead = "Metin Zontul";
            string[] degrees = { "Software Engineering", "Civil Engineering" };


            //Degree Information

            string degreeName = "Software Engineering";
            int creditsRequired = 120;

            // Course Information
            string courseName = "Data Structures";
            int credits = 4;
            int durationInWeeks = 14;
            string teacher = "Dan Johnson";



            Console.WriteLine(teacherFirstName);
            Console.WriteLine(teacherLastName);
            Console.WriteLine($"Born on {teacherBirthDate}");
        }
    }
}
