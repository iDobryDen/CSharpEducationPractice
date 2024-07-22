using System;

namespace Task2._6;

//Напишите программу, которая вычисляет длину катетов и гипотенузы.Все известные значения храните в переменных,
//а результаты вычислений выведите в консоль:
    //a.Известны два катета - найти гипотенузу
    //b.Известен один катет и гипотенуза - найти второй катет

class Program
{
    static void Main(string[] args)
    {
        double leg1 = 5;
        double leg2 = 7;
        double sq_hypotenuse = leg1 * leg1 + leg2 * leg2;
        double hypotenuse = Math.Sqrt(sq_hypotenuse);

        Console.WriteLine($"Гипотенуза равна: { hypotenuse }");

        double leg3 = 8;
        double hypotenuse2 = 35;
        double sq_leg4 = hypotenuse2 * hypotenuse2 - leg3 * leg3;
        double leg4 = Math.Sqrt(sq_leg4);

        Console.WriteLine($"Второй катет равен: {leg4}");
    }
}

