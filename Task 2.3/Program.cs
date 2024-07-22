namespace Task_2._3;

//Напишите программу, которая считывает из консоли ваше имя и выводит
//приветственное сообщение.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите Ваше имя");

        string Name = Console.ReadLine();

        Console.WriteLine("Приветствую " + Name);
    }
}

