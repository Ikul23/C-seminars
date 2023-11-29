// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//  Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(double min, double max, int size) // метод, задающий рандомный массив из вещественных чисел
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = min + (max - min) * random.NextDouble();
    }
    return array;
}

void ShowArray(double[] array) // метод, выводящий рандомный массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMinMax(double[] array) // метод, определяющий разницу между максимальным и минимальным элементом массива
{
    double num_max = array[0];
    double num_min = array[0];

    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] > num_max)
        {
            num_max = array[j];
        }

        if (array[j] < num_min)
        {
            num_min = array[j];
        }
    }

    return num_max - num_min;
}

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальное значение массива");
double min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение массива");
double max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(min, max, size);
ShowArray(array);

double difference = FindMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {difference}");
