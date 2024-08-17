using System.Xml.Linq;

namespace Practice5.Task1;

//Класс Employee. Делайте в одном проекте.
//  a.Создайте базовый класс Employee с полями Name и Salary, а также
//      методом CalculateBonus(), который возвращает 10% от зарплаты.Создайте производный класс Manager,
//      который переопределяет метод CalculateBonus(), чтобы возвращать 20% от зарплаты. Создайте объекты обоих классов, вызовите
//      метод и выведите результат на экран.
//  b.Расширьте класс Employee, добавив конструктор, принимающий имя и зарплату. В классе Manager добавьте
//      дополнительное поле TeamSize.Реализуйте конструктор в классе Manager, который вызывает конструктор базового класса
//      с помощью base и устанавливает значение TeamSize. В методе CalculateBonus() учитывайте размер команды: если команда больше 5 человек,
//      бонус должен увеличиваться на 5%.
//  c.Создайте новый класс Contractor, унаследованный от Employee, который добавляет поле HourlyRate и скрывает метод CalculateBonus(),
//      делая его зависящим от отработанных часов. Реализуйте метод CalculateBonus(int hoursWorked). Создайте список сотрудников, включая
//      Contractor, и реализуйте приведение типов, чтобы рассчитать бонусы для всех сотрудников, независимо от типа.

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Ivan", 20000);
        Manager manager = new Manager("Roman", 30000);

        Print(employee);
        Console.WriteLine("----------------");
        Print(manager);
    }

    static void Print(Employee employee)
    {
        Console.WriteLine(employee.Name);
        Console.WriteLine(employee.Salary);
        Console.WriteLine(employee.CalculateBonus(employee.Salary));
    }

    static void Print(Manager manager)
    {
        Console.WriteLine(manager.Name);
        Console.WriteLine(manager.Salary);
        Console.WriteLine(manager.CalculateBonus(manager.Salary));
    }
}

