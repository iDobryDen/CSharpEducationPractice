namespace Task2._5;

//Напишите программу, которая вычисляет формулу площади круга и выводит
//результат на экран консоли с понятным сообщением.Число π запишите как константу и
//используйте её в формуле.Радиус запишите как переменную.Считывать из консоли ничего не нужно.

class Program
{
    static void Main(string[] args)
    {
        double pi = 3.14;
        int R = 5;
        double area_cirle = pi * R * R;
        Console.WriteLine("area of ​​cirle:" + area_cirle);
    }
}

