using System;
namespace Mod3_Self_Assesment_Lab
{
    public class Degree
    {
        public Degree(string degName, int creditsReq)
        {
            this.DegreeName = degName;
            this.CreditsRequired = creditsReq;
        }

        private string degreeName;
        private int creditsRequired;
        private Course[] courses = new Course[3];

        public string DegreeName { get => degreeName; set => degreeName = value; }
        public int CreditsRequired { get => creditsRequired; set => creditsRequired = value; }
        public Course[] Courses { get => courses; set => courses = value; }
    }
}
