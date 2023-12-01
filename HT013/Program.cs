// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size) // метод, задающий рандомный массив, заполненный трехзначными цифрами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArray(size);
ShowArray(array);

int count = FindEvenCounts(array);
Console.WriteLine($"Количество четных элементов в массиве равно {count}");