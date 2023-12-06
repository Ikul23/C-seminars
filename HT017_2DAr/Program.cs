// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
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

int MinRowsSum(int[,] array) // метод для расчета минимальной суммы элементов и вычисления индекса строки через создания одномерного массива
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] sumRows = new int[rows]; // Одномерный массив для хранения сумм элементов по строкам

    for (int i = 0; i < rows; i++) // Вычисление сумм элементов по каждой строке
    {
        for (int j = 0; j < cols; j++)
        {
            sumRows[i] += array[i, j];
        }
    }
    int minSum = sumRows[0]; // Поиск индекса строки с минимальной суммой
    int minIndex = 0;

    for (int i = 1; i < rows; i++)
    {
        if (sumRows[i] < minSum)
        {
            minSum = sumRows[i];
            minIndex = i;
        }
    }
    return minIndex;
}
Console.WriteLine("Задайте количество строк двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив сформирован: ");
int[,] array = Create2dArray(row, col);
Show2dArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов имеет индекс: {MinRowsSum(array)}");