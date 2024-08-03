namespace Pracice2.Task9;

//Напишите метод, который создаёт массив целых чисел и возвращает его.
//Размер массива нужно передавать в качестве аргумента.Вдобавок напишите
//метод, который выводит переданный массив на экран консоли.

class Program
{
    static void Main(string[] args)
    {
        int size = 3;
        int[] array = Value(size);
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[j]);
        }
    }

    static int[] Value(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        return array;
    }
}

