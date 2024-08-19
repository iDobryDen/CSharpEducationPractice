namespace Practice2.Task7;

//Напишите программу, которая переводит строку в разные регистры
    //a. в верхний регистр: f -> F
    //b. в нижний регистр: F -> f
    //c. делает заглавную букву в слове: привет -> Привет

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Верхний регистр:");
        Console.WriteLine(inputString.ToUpper());

        Console.WriteLine("Нижний регистр:");
        string lowerString = inputString.ToLower();
        Console.WriteLine(lowerString);
        
        char firstSumbol = lowerString[0];
        char upperFirstSumbol = char.ToUpper(firstSumbol);
        string titleSumbolString = upperFirstSumbol + lowerString.Substring(1);
        
        Console.WriteLine("Заглавная буква:");
        Console.WriteLine(titleSumbolString);
    }
}