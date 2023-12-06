// *(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца
// 4 3 1 =>    2 6
// 2 6 9       4 6
// 4 6 2

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

int[,] NewArrayDel(int[,] newArray)
{
    int rows = newArray.GetLength(0);
    int cols = newArray.GetLength(1);

    int min = newArray[0, 0]; 
    int rowIndex = 0;
    int colIndex = 0;

    for (int i = 0; i < rows; i++) // определяем позицию минимального элемента массива
    {
        for (int j = 0; j < cols; j++)
        {
            if (min > newArray[i, j])
            {
                rowIndex = i;
                colIndex = j;
                min = newArray[i, j];
            }
        }
    }

    int[,] delArray = new int[rows - 1, cols - 1]; // задаем новый двумерный массив без строк и столбцов с минимальным элементом массива
    int newRow = 0;
    int newCol;

    for (int a = 0; a < rows; a++)
    {
        if (a != rowIndex) // задаем условия удаления строк
        {
            newCol = 0;

            for (int b = 0; b < cols; b++) // задаем условия удаления строк
            {
                if (b != colIndex)
                {
                    delArray[newRow, newCol] = newArray[a, b];
                    newCol++;
                }
            }

            newRow++;
        }
    }

    return delArray;
}


Console.WriteLine("Задайте количество строк двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив сформирован: ");
int[,] newArray = Create2dArray(row, col);
Show2dArray(newArray);
Console.WriteLine();

Console.WriteLine("Новый двумерный массив после удаления строки и столбца: ");
int[,] delArray = NewArrayDel(newArray);
Show2dArray(delArray);
