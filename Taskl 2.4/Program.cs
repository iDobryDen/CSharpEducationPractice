namespace Taskl_2._4;

//Напишите программу, которая считывает из консоли фразу и сохраняет её.
//Затем считывает вторую фразу и выводит на экран консоли обе этих фразы,
//объединённые в одно предложение. (Пример: ввели “Привет”, а затем “мир”. В
//консоли отобразится “Привет мир”).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу: ");
        string phrase1 = Console.ReadLine();
        Console.WriteLine("Введите вторую фразу: ");
        string phrase2 = Console.ReadLine();
        Console.WriteLine(phrase1 +" " + phrase2);
    }
}

