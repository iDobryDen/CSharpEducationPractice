namespace Practice5.Task1;

public class Contractor : Employee
{
    public int HourlyRate;

    public Contractor(string name, double salary, int HourlyRate, int HoursWorked) : base (name, salary)
    {
        this.HourlyRate = HourlyRate;
        this.HoursWorked = HoursWorked;
    }

    public new int CalculateBonus(int HoursWorked) 
    {
        double bonus = HoursWorked * HourlyRate;
        return (int)Math.Round(bonus);
    }
}