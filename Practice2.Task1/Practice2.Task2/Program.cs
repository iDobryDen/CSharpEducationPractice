namespace Practice2.Task2;

//Напишите программу, которая переводит:
    //a.метры в километры
    //b.километры в сантиметры
    //c.м/с в км/ч
    //d. градусы C в градусы F

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("A. метры в километры.");

        Console.WriteLine("Введите расстояние в метрах");
        int metrs = int.Parse(Console.ReadLine());
        float km = metrs / 1000f; // Используем 1000f для получения float значения

        Console.WriteLine($"Расстояние в километрах равно: " + km);
    }
}

