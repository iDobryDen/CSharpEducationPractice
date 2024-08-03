namespace Practice2.Task5;

//Напишите программу для сравнения двух целых чисел. Ввод осуществляйте через консоль.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите первое число");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("введите второе число");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("первое число больше второго");
        }
        else if (a == b)
        {
            Console.WriteLine("числа равны");
        }
        else
        {
            Console.WriteLine("первое число меньше второго");
        }
    }
}

