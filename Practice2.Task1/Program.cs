namespace Practice2.Task1;

//Напишите цикл следующего вида:
    //a.цикл for. Пусть он выводит в консоль значение своего же счётчика.
    //b.цикл while. Пусть он выводит в консоль значение своего же счётчика.
    //c.цикл do while. Пусть он выводит в консоль значение своего же счётчика.
    //d.цикл for, в котором у пользователя запрашиваются слова, затем
    //выводится полная фраза, слова в которой разделены пробелами.
    //e.цикл while, в котором у пользователя запрашиваются слова, затем
    //выводится полная фраза, слова в которой разделены пробелами.
    //f.цикл do while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелам

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A. цикл for. Пусть он выводит в консоль значение своего же счётчика.");
        int a = 2;

        for (int i = 0; i < a; i++ )
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("B. цикл while. Пусть он выводит в консоль значение своего же счётчика.");

        while (a >= 1)
        {
            a--;
            Console.WriteLine(a);
        }

        Console.WriteLine("C. цикл do while. Пусть он выводит в консоль значение своего же счётчика");

        int Bbb = 2;
        do
        {
            Bbb--;
            Console.WriteLine(Bbb);
        }
        while (Bbb >= 1);

        Console.WriteLine("D. цикл for, в котором у пользователя запрашиваются слова, " +
                            "затем выводится полная фраза, слова в которой разделены пробелами.");

        string[] phrase = new string[3];

        for (int k = 0; k < phrase.Length; k++)
        {
            Console.WriteLine("Введите слово из фразы");
            phrase[k] = Console.ReadLine();
        }

        for (int m = 0; m < phrase.Length; m++)
        {
            Console.Write(phrase[m] + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("E. цикл while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, " +
                            " слова в которой разделены пробелами.");

        string[] phrase2 = new string[3];
        int count = 0;
        while (count < phrase2.Length)
        {
            Console.WriteLine("Введите слово из фразы");
            phrase2[count] = Console.ReadLine();
            count++;
        }

        count = 0;
        while (count < phrase2.Length)
        {
            Console.Write(phrase2[count] + " ");
            count++;
        }

        Console.WriteLine(" ");
        Console.WriteLine("F. цикл do while, в котором у пользователя запрашиваются слова, " +
                            "затем выводится полная фраза, слова в которой разделены пробелам.");

        string[] phrase3 = new string[4];
        count = 0;
        do
        {
            Console.WriteLine("Введите слово из фразы");
            phrase3[count] = Console.ReadLine();
            count++;
        }
        while (count < phrase3.Length);

        count = 0;
        do
        {
            Console.Write(phrase3[count] + " ");
            count++;
        }
        while (count < phrase3.Length);
    }
}

