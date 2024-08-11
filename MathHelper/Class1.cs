namespace MathLibrary;

//1.	Создай библиотеку классов, в которой будет класс "MathHelper" с методами для выполнения основных математических операций
//    (сложение, вычитание, умножение, деление).
//    Убедись, что библиотека компилируется без ошибок.

public class MathHelper
{
    public void Sum(int a, int b)
    {
        float result = a + b;
        Console.WriteLine(result);
    }

    public void Subtraction(int a, int b)
    {
        float result = a - b;
        Console.WriteLine(result);
    }

    public void Multiplication(int a, int b)
    {
        float result = a * b;
        Console.WriteLine(result);
    }

    public void Division(int a, int b)
    {
        float result = a / b;
        Console.WriteLine(result);
    }
}
