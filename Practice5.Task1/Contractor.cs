namespace Practice5.Task1;

public class Contractor : Employee
{
    public int HourlyRate;
    public int HoursWorked;

    public Contractor(string name, double salary, int HourlyRate, int HoursWorked) : base (name, salary)
    {
        this.HourlyRate = HourlyRate;
        this.HoursWorked = HoursWorked;
    }

    public new int CalculateBonus(int HoursWorked) //override тоже не подходит????
    {
        double bonus = HoursWorked * HourlyRate;
        return (int)Math.Round(bonus);
    }
}