﻿namespace Practice2.Task2;

//Напишите программу, которая переводит:
    //a.метры в километры
    //b.километры в сантиметры
    //c.м/с в км/ч
    //d. градусы C в градусы F

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("A. метры в километры.");

        Console.WriteLine("Введите расстояние в метрах");
        int metrs = int.Parse(Console.ReadLine());
        float km = metrs / 1000f; // Используем 1000f для получения float значения

        Console.WriteLine($"Расстояние в километрах равно: " + km);

        Console.WriteLine(" ");
        Console.WriteLine("B. километры в сантиметры.");

        Console.WriteLine("Введите расстояние в км");
        int km2 = int.Parse(Console.ReadLine());
        long cm = km2 * 1000 * 100;

        Console.WriteLine($"Расстояние в сантиметрах равно: " + cm);

        Console.WriteLine(" ");
        Console.WriteLine("C. м/с в км/ч.");

        Console.WriteLine("Введите скорость в м/с");
        int speedMPS = int.Parse(Console.ReadLine()); // MPS - MetersPerSecond
        float speedKPH = speedMPS * 3.6f; // KPH - KilometersPerHour

        Console.WriteLine($"Скорость в км/ч равна: " + speedKPH);

        Console.WriteLine(" ");
        Console.WriteLine("D. градусы C в градусы F.");

        Console.WriteLine("Введите температуру в градусах Цельсия");
        int celsius = int.Parse(Console.ReadLine());
        float fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Температура в градусах Фарингейта равна: " + fahrenheit);
    }
}

