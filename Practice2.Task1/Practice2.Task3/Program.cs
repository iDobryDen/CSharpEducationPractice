namespace Practice2.Task3;

//Напишитепрограммудлявычислениявыражения(а + b — f / а) + f * a * a — (a + b). Все переменные задаются пользователем.Учтите деление на 0.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a");
        int a = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Переменная a не может быть равна 0");
            return;
        }

        Console.WriteLine("Input b");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Input f");
        int f = int.Parse(Console.ReadLine());

        int result = (a + b - f / a) + f * a * a - (a + b);
        Console.WriteLine($"выражение равно: " + result);
    }
}

