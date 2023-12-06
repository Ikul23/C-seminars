// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

int[,] Create2dArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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

int[,] ReversedArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] changedArray = new int[rows, cols];

    for (int j = 0; j < cols; j++)
    {
        changedArray[0, j] = array[rows - 1, j];  // Копируем последнюю строку на место первой
    }
     for (int i = 1; i < rows - 1; i++)  
    {
        for (int j = 0; j < cols; j++)
        {
            changedArray[i, j] = array[i, j]; // Копируем среднюю строку без изменений
        }
    }
    for (int j = 0; j < cols; j++)
    {
        changedArray[rows - 1, j] = array[0, j]; // Копируем первую строку на место последней
    }

    return changedArray;
}
Console.WriteLine("Задайте количество строк двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив сформирован: ");
int[,] array = Create2dArray(row, col);
Show2dArray(array);
Console.WriteLine();

Console.WriteLine("Массив после замены первой и последней строк: ");
int[,] changedArray = ReversedArray(array);
Show2dArray(changedArray);