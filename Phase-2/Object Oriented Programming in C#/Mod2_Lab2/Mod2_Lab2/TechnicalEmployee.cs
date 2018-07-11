using System;
namespace Mod2_Lab2
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(String name, int salary) : base(name, salary)
        {

        }

        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
