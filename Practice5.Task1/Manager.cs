using System;
namespace Practice5.Task1
{
	public class Manager : Employee
	{
		public Manager(string name, double salary) : base (name, salary)
		{
		}

        public int CalculateBonus(double Salary)
        {
            double per = Salary * 0.2;
            return (int)Math.Round(per);
        }
    }
}

