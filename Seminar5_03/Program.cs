// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий из 
// средних арифметических значений по строкам двумерного массива. 

int[,] Create2dArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double [] Average2dArray(int [,] array){
    double [] createdArray = new double [array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++){
        double count = 0;
        for(int j = 0; j<array.GetLength(1); j++){
            count+=array[i,j];
        }
        createdArray[i] = count/array.GetLength(0);
    }
    return createdArray;
}
Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] created2dArray = Create2dArray(row, col, min, max);
Show2dArray(created2dArray);
Console.WriteLine();
ShowArrayDiago(count);