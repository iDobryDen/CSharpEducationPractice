using System;
namespace Practice5.Task1
{
	public class Manager : Employee
	{
        int TeamSize;

        public Manager(string name, double salary, int TeamSize) : base (name, salary)
		{
            this.TeamSize = TeamSize;
        }

        public new int CalculateBonus(double Salary)
        {
            if (TeamSize < 5)
            {
                double per = Salary * 0.2;
                return (int)Math.Round(per);
            }
            else
            {
                double per = Salary * 0.25;
                return (int)Math.Round(per);
            }
            
        }
    }
}


