using System;
using System.Xml.Linq;

namespace Practice5.Task1
{
	public class Employee
	{
		public string Name;
		public double Salary;

		public Employee(string name, double salary)
        {
			this.Name = name;
            this.Salary = salary;
        }

        public virtual int CalculateBonus(double Salary)
        {
			double per = Salary * 0.1;
            return (int)Math.Round(per);
        }
    }
}

