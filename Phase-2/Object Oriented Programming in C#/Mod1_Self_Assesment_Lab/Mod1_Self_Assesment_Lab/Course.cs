using System;
namespace Mod1_Self_Assesment_Lab
{
    public class Course
    {

        public Course(string courseName, int credits, int durationInWeeks)
        {
            this.CourseName = courseName;
            this.Credits = credits;
            this.DurationInWeeks = durationInWeeks;
        }

        private string courseName;
        private int credits;
        private int durationInWeeks;
        private Teacher[] teacher = new Teacher[2];
        private Student[] students = new Student[5];

        public string CourseName { get => courseName; set => courseName = value; }
        public int Credits { get => credits; set => credits = value; }
        public int DurationInWeeks { get => durationInWeeks; set => durationInWeeks = value; }
        public Teacher[] Teacher { get => teacher; set => teacher = value; }
        public Student[] Students { get => students; set => students = value; }
    }
}
