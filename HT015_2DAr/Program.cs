// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9 
int[,] Create2dArray(int row, int col) // для упрощения, в данном методе массив ограничен 3-мя строками и 3-мя столбцами
{
    int[,] array = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array, int findRow, int findCol)
    {
        if (findRow >= 0 && findRow < array.GetLength(0) && findCol >= 0 && findCol < array.GetLength(1))
        {
            Console.WriteLine($"Значение элемента по индексам ({findRow}, {findCol}): {array[findRow, findCol]}");
        }
        else
        {
            Console.WriteLine($"Элемента с индексами ({findRow}, {findCol}) нет в данном массиве.");
        }
    }

Console.WriteLine("Исходный массив сформирован: ");   
int[,] created2dArray = Create2dArray(3, 3);
Show2dArray(created2dArray);
Console.WriteLine();

Console.WriteLine("Введите искомое значение индекса (от 0 до 2) строки исходного массива : ");
int findRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое значение индекса (от 0 до 2) столбца данного массива: ");
int findCol = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
FindElement(created2dArray, findRow, findCol);