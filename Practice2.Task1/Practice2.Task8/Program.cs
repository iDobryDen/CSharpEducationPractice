namespace Practice2.Task8;

//Составить алгоритм увеличения всех трех, введенных с клавиатуры,
//переменных на 5,если среди них есть хотя бы две равные.В противном случае
//выдать ответ «равных нет».

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите первое число");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("введите второе число");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("введите третье число");
        int c = int.Parse(Console.ReadLine());

        if (a == b || a == c || b == c)
        {
            int a2 = a * 5;
            int b2 = b * 5;
            int c2 = c * 5;
            Console.WriteLine(a2 + " " + b2 + " " + c2);
        }
        else
        {
            Console.WriteLine("равных нет");
        }
    }
}