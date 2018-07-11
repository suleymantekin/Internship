using System;

namespace Mod2_Self_Assesment_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var informationTechnology = new UProgram("Information Technology", "Metiz Zontul");
            var bachelor = new Degree("Bachelor", 120);
            var programmingWithCSharp = new Course("Programming with C#", 24, 4);

            informationTechnology.Degrees[0] = bachelor;
            bachelor.Courses[0] = programmingWithCSharp;

            var Ali = new Student("Ali", "Er", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Dan = new Student("Dan", "Johnson", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            var Paul = new Student("Paul", "Cole", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            programmingWithCSharp.Students[0] = Ali;
            programmingWithCSharp.Students[1] = Dan;
            programmingWithCSharp.Students[2] = Paul;

            var Tom = new Teacher("Tom", "Thumb", DateTime.Now, "1st Ave", " ", "Moncton", "NB", "E1C 4W3", "Canada");
            programmingWithCSharp.Teacher[0] = Tom;

            Console.WriteLine(informationTechnology.ProgramName + " program has " + informationTechnology.Degrees[0].DegreeName + " degree.\n");
            Console.WriteLine(bachelor.DegreeName + " degree has " + bachelor.Courses[0].CourseName + " course.\n");
            Console.WriteLine($"There are {Student.CountStudent()} students in the {programmingWithCSharp.CourseName} course.\n");

            Ali.TakeTest();
            Tom.GradeTest();
        }
    }
}
