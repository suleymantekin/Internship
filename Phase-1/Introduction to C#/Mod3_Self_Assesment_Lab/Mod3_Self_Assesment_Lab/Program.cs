using System;

namespace Mod3_Self_Assesment_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Student Information
            string studentFirstName;
            string studentLastName;
            DateTime studentBirthDate;
            string studentAdressLine1;
            string studentAdressLine2;
            string studentCity;
            string studentState;
            string studentPostal;
            string studentCountry;

            GetStudentInformation(out studentFirstName, out studentLastName, out studentBirthDate, out studentAdressLine1, out studentAdressLine2, out studentCity, out studentState, out studentPostal, out studentCountry);

            PrintStudentDetails(studentFirstName, studentLastName, studentBirthDate, studentAdressLine1, studentAdressLine2, studentCity, studentState, studentPostal, studentCountry);


            // Teacher Information
            string teacherFirstName;
            string teacherLastName;
            DateTime teacherBirthDate;
            string teacherAdressLine1;
            string teacherAdressLine2;
            string teacherCity;
            string teacherState;
            string teacherPostal;
            string teacherCountry;

            GetTeacherInformation(out teacherFirstName, out teacherLastName, out teacherBirthDate, out teacherAdressLine1, out teacherAdressLine2, out teacherCity, out teacherState, out teacherPostal, out teacherCountry);

            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherBirthDate, teacherAdressLine1, teacherAdressLine2, teacherCity, teacherState, teacherPostal, teacherCountry);

            //UProgram Information
            string programName;
            string departmentHead;
            string[] degrees;

            GetUProgramtInformation(out programName, out departmentHead, out degrees);
            PrintUProgramDetails(programName, departmentHead, degrees);


            //Degree Information

            string degreeName;
            int creditsRequired;
            GetDegreeInformation(out degreeName, out creditsRequired);
            PrintDegreeDetails(degreeName, creditsRequired);

            // Course Information
            string courseName;
            int credits;
            int durationInWeeks;
            string teacher;
            GetCourseInformation(out courseName, out credits, out durationInWeeks, out teacher);

            try{
                PrintCourseDetails(courseName, credits, durationInWeeks, teacher);
            } catch(NotImplementedException notImp){
                Console.WriteLine(notImp.Message);
            }
        }

        static void GetStudentInformation(out string studentFirstName, out string studentLastName, out DateTime studentBirthDate, out string studentAdressLine1, out string studentAdressLine2, out string studentCity, out string studentState, out string studentPostal, out string studentCountry)
        {
            // Student Information
            Console.WriteLine("Enter student name");
            studentFirstName = Console.ReadLine();

            Console.WriteLine("Enter student last name");
            studentLastName = Console.ReadLine();

            Console.WriteLine("Enter student birthdate");
            studentBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter student address line 1");
            studentAdressLine1 = Console.ReadLine();

            Console.WriteLine("Enter student address line 2");
            studentAdressLine2 = Console.ReadLine();

            Console.WriteLine("Enter student city");
            studentCity = Console.ReadLine();

            Console.WriteLine("Enter student state");
            studentState = Console.ReadLine();

            Console.WriteLine("Enter student postal");
            studentPostal = Console.ReadLine();

            Console.WriteLine("Enter student country");
            studentCountry = Console.ReadLine();
        }

        static void GetTeacherInformation(out string teacherFirstName, out string teacherLastName, out DateTime teacherBirthDate, out string teacherAdressLine1, out string teacherAdressLine2, out string teacherCity, out string teacherState, out string teacherPostal, out string teacherCountry)
        {
            // Teacher Information
            Console.WriteLine("Enter teacher name");
            teacherFirstName = Console.ReadLine();

            Console.WriteLine("Enter teacher last name");
            teacherLastName = Console.ReadLine();

            Console.WriteLine("Enter teacher birthdate");
            teacherBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter teacher address line 1");
            teacherAdressLine1 = Console.ReadLine();

            Console.WriteLine("Enter teacher address line 2");
            teacherAdressLine2 = Console.ReadLine();

            Console.WriteLine("Enter teacher city");
            teacherCity = Console.ReadLine();

            Console.WriteLine("Enter teacher state");
            teacherState = Console.ReadLine();

            Console.WriteLine("Enter teacher postal");
            teacherPostal = Console.ReadLine();

            Console.WriteLine("Enter teacher country");
            teacherCountry = Console.ReadLine();

        }
        static void GetUProgramtInformation(out string programName, out string departmentHead, out string[] degrees)
        {

            //UProgram Information
            Console.WriteLine("Enter program name");
            programName = Console.ReadLine();

            Console.WriteLine("Enter department head");
            departmentHead = Console.ReadLine();

            Console.WriteLine("Enter degrees (seperate with comas)");
            degrees = Console.ReadLine().Split(',');
        }



        static void GetDegreeInformation(out string degreeName, out int creditsRequired)
        {
            //Degree Information
            Console.WriteLine("Enter degree name");
            degreeName = Console.ReadLine();

            Console.WriteLine("Enter credits required (int)");
            creditsRequired = Convert.ToInt32(Console.ReadLine());
        }



        static void GetCourseInformation(out string courseName, out int credits, out int durationInWeeks, out string teacher)
        {
            // Course Information
            Console.WriteLine("Enter course name");
            courseName = Console.ReadLine();

            Console.WriteLine("Enter credits (int)");
            credits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter duration in weeks (int)");
            durationInWeeks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter teacher");
            teacher = Console.ReadLine();

        }

        static void PrintStudentDetails(string studentFirstName, string studentLastName, DateTime studentBirthDate, string studentAdressLine1, string studentAdressLine2, string studentCity, string studentState, string studentPostal, string studentCountry)
        {
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
        }

        static void PrintTeacherDetails(string teacherFirstName, string teacherLastName, DateTime teacherBirthDate, string teacherAdressLine1, string teacherAdressLine2, string teacherCity, string teacherState, string teacherPostal, string teacherCountry)
        {
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
        }

        static void PrintUProgramDetails(string programName, string departmentHead, string[] degrees)
        {
            //Print UProgram Information
            Console.WriteLine("------Print UProgram Information------");
            Console.WriteLine(programName);
            Console.WriteLine(departmentHead);
            Console.WriteLine(string.Join(" ", degrees) + "\n\n\n");
        }


        static void PrintDegreeDetails(string degreeName, int creditsRequired)
        {
            // Print Degree Information
            Console.WriteLine("------Degree Course Information------");
            Console.WriteLine(degreeName);
            Console.WriteLine(creditsRequired + "\n\n\n");

        }


        static void PrintCourseDetails(string courseName, int credits, int durationInWeeks,  string teacher)
        {
        //    // Print Course Information
        //    Console.WriteLine("------Print Course Information------");
        //    Console.WriteLine(courseName);
        //    Console.WriteLine(credits);
        //    Console.WriteLine(durationInWeeks);
        //    Console.WriteLine(teacher + "\n\n\n");
            throw new NotImplementedException();
        }
    }
}
