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

            Console.WriteLine("Enter student birthdate");
            DateTime studentBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter student address line 1");
            string studentAdressLine1 = Console.ReadLine();

            Console.WriteLine("Enter student address line 2");
            string studentAdressLine2 = Console.ReadLine();

            Console.WriteLine("Enter student city");
            string studentCity = Console.ReadLine();

            Console.WriteLine("Enter student state");
            string studentState = Console.ReadLine();

            Console.WriteLine("Enter student postal");
            string studentPostal = Console.ReadLine();

            Console.WriteLine("Enter student country");
            string studentCountry = Console.ReadLine();



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


            // Print Student Information
            Console.WriteLine("\n\n\n------Print Student Information------");
            Console.WriteLine(studentFirstName);
            Console.WriteLine(studentLastName);
            Console.WriteLine($"Born on {studentBirthDate}");
            Console.WriteLine(studentAdressLine1 + " " + studentAdressLine2);
            Console.WriteLine(studentCity);
            Console.WriteLine(studentState);
            Console.WriteLine(studentPostal);
            Console.WriteLine(studentCountry + "\n\n\n");

            // Print Teacher Information
            Console.WriteLine("------Print Teacher Information------");
            Console.WriteLine(teacherFirstName);
            Console.WriteLine(teacherLastName);
            Console.WriteLine($"Born on {teacherBirthDate}");
            Console.WriteLine(teacherAdressLine1 + " " + teacherAdressLine2);
            Console.WriteLine(teacherCity);
            Console.WriteLine(teacherState);
            Console.WriteLine(teacherPostal);
            Console.WriteLine(teacherCountry + "\n\n\n");


            //Print UProgram Information
            Console.WriteLine("------Print UProgram Information------");
            Console.WriteLine(programName);
            Console.WriteLine(departmentHead);
            Console.WriteLine(string.Join(" ", degrees) + "\n\n\n");


            // Print Degree Information
            Console.WriteLine("------Degree Course Information------");
            Console.WriteLine(degreeName);
            Console.WriteLine(creditsRequired + "\n\n\n");


            // Print Course Information
            Console.WriteLine("------Print Course Information------");
            Console.WriteLine(courseName);
            Console.WriteLine(credits);
            Console.WriteLine(durationInWeeks);
            Console.WriteLine(teacher + "\n\n\n");

        }
    }
}
