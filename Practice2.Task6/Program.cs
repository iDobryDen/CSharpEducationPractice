namespace Practice2.Task6;

//Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.
    //a. строка и символ указываются программно
    //b. строка и символ указываются пользователем в консоли

class Program
{
    static void Main(string[] args)
    {
        // a. Строка и символ указываются программно
        string inputString = "my string is very very long string";
        char searchSymbol = 'r';
        PrintPercentage(inputString, searchSymbol);

        // b. Строка и символ указываются пользователем в консоли
        Console.WriteLine("Введите строку:");
        string myString = Console.ReadLine();
        Console.WriteLine("Введите символ:");
        char mySymbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        PrintPercentage(myString, mySymbol);
    }

    static void PrintPercentage(string inputString, char searchSymbol)
    {
        int count = 0;
        foreach (char symbol in inputString)
        {
            if (symbol == searchSymbol)
            {
                count++;
            }
        }
        double percentage = (double)count / inputString.Length * 100;
        Console.WriteLine($"Процент вхождения символа '{searchSymbol}' в строку: {percentage:F3}%");
    }
}