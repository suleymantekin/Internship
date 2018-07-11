using System;
namespace Mod2_Lab2
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(String name, int salary) : base(name, salary)
        {
        }

        public override String employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
