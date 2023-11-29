// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] CreateArray(int min, int max, int size) // метод, создающий рандомный массив
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

void ShowArray(int[] array) // метод. выводящий рандомный массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindCounts(int[] array) // метод, определяющий количество чисел в заданном отрезке
{
    int count = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] >= 20 && array[j] <= 90)
        {
            count++;
        }
    }

    return count;
}

int max = 100; 
int min = 1;
int size = 10;

int[] array = CreateArray(min, max, size);
ShowArray(array);

int count = FindCounts(array);
Console.WriteLine($"Количество элементов в отрезке массива [20, 90] равно {count}");