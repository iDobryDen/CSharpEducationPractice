namespace Practice3.Task2_done;

//Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет выводить информацию о студенте в консоль
//. Добавь в класс "Студент" свойство "Средний балл". Реализуй геттер и сеттер для этого свойст
//ва. Добавь проверку в сеттер, чтобы значение среднего балла было в диапазоне от 0 до 5.

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        Console.WriteLine("Введите средний балл");
        student.averageScore = float.Parse(Console.ReadLine());
          
        student.PrintInfo("Den", 36, student.averageScore);
    }
}

public class Student
{
    public string name;
    public int age;
    public float averageScore { get; set; } //посмотреть лекции

    public void PrintInfo(string name, int age, float averageScore)
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Средний балл: {averageScore}");
    }

}
