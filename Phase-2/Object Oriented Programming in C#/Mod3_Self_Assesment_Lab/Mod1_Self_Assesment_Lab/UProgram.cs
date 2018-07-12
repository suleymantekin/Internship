using System;
namespace Mod3_Self_Assesment_Lab
{
    public class UProgram
    {
        public UProgram(string progName, string depHead){
            this.ProgramName = progName;
            this.DepartmentHead = depHead;
        }

        private string programName;
        private string departmentHead;
        private Degree[] degrees = new Degree[3];

        public string ProgramName { get => programName; set => programName = value; }
        public string DepartmentHead { get => departmentHead; set => departmentHead = value; }
        public Degree[] Degrees { get => degrees; set => degrees = value; }
    }
}
