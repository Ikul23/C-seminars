// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int min, int max, int size) // метод, создающий рандомный массив
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] rArray) // метод переворачивания массива
{
    int[] reversedArray = new int[rArray.Length];

    for (int i = 0; i < rArray.Length; i++)
    {
        reversedArray[i] = rArray[rArray.Length - 1 - i];
    }
    Array.Copy(reversedArray, rArray, rArray.Length); // копирует обратно в r_array перевернутый массив
}
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(min, max, size);
ShowArray(array);

ReverseArray(array);
ShowArray(array);

