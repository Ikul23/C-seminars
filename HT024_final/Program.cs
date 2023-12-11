// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] CreateArray(int min, int max)
{

    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(min, max);
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
string NumbersRec(int[] array, int index) // метод вывода произвольного массива в обратном порядке с помощью рекурсии
{
    if (index >= 0)
        return $"{array[index]} " + NumbersRec(array, index - 1);
    else
        return string.Empty;
}

Console.WriteLine("Задайте минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArray(min, max);
ShowArray(array);

Console.WriteLine(NumbersRec(array, array.Length - 1));
