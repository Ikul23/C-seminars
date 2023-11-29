// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] CreateArray(int min, int max) // метод, задающий рандомный массив на 10 целых чисел 
{

    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int[] array) // метод, выводящий рандомный массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindEvenCounts(int[] array) // метод, определяющий количество четных чисел в массиве
{
    int count = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0 && array[j] != 0)
        {
            count++;
        }


    }
    return count;

}

Console.WriteLine("Задайте минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArray(min, max);
ShowArray(array);

int count = FindEvenCounts(array);
Console.WriteLine($"Количество четных элементов в массиве равно {count}");