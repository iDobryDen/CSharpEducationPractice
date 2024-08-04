using System.Xml.Linq;

namespace Practice3.Task3;

//Создай класс "Калькулятор" с методами для выполнения основных арифметических операци
//й(сложение, вычитание, умножение, деление). Пусть эти методы принимают два числа и возвращают результат операции.

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();


        Console.WriteLine("Введите первое значение");
        int a = int.Parse(Console.ReadLine());
    }
}

public class Calculator
{

    public void Sum(int a, int b)
    {
        float result = a / b;
        Console.WriteLine(result);
    }

    public void Subtraction(int a, int b)
    {
        float result = a / b;
        Console.WriteLine(result);
    }

    public void Multiplication(int a, int b)
    {
        float result = a / b;
        Console.WriteLine(result);
    }

    public void Division(int a, int b)
    {
        float result = a / b;
        Console.WriteLine(result);
    }
}