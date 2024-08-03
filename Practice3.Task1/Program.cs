namespace Practice3.Task1;

//Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет выводить информацию о студенте в консоль.

public class Program
{

    public static void Main(string[] args)
    {
        Student student = new Student();
        student.name = "Den";
        student.age = 36;

        student.PrintInfo();
    }
}

public class Student
{
    public string name;
    public int age;

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }

}

