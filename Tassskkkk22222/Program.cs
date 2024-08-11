using MathLibrary;

//2.Создай новый проект и подключи к нему библиотеку классов, созданную в предыдущем задании. Используй методы из класса
//"MathHelper" для выполнения простых математических операций в этом проекте.

namespace Tassskkkk22222;

class Program
{
    static void Main(string[] args)
    {
        MathHelper mathHelper = new MathHelper();


        mathHelper.Sum(5, 3);
        mathHelper.Subtraction(5, 3);
        mathHelper.Multiplication(5, 3);
        mathHelper.Division(5, 2);
    }
}

