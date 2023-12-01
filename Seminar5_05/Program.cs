//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая заменит все элементы в  
//строке и столбеце на 0, на пересечении которых 
//расположен наименьший элемент массива.

int[,] Create2dArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max);
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

int [,] MyArray(int[,] array){
    int min = array[0,0];
    int rowIndex = 0;
    int colIndex = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if (min>array[i,j]){
                rowIndex = i;
                colIndex = j;
                min = array[i,j];
            }
        }
    }
    for(int i = 0; i<array.GetLength(0); i++){
        array[i,colIndex] = 0;
    }
    for(int j = 0; j<array.GetLength(1); j++){
        array[rowIndex,j] = 0;
    }
    return array;

}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int [,] created2dArray = Create2dArray(row,col,min,max);
//int [,] sumArr = SumArray(row,col);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int [,] changedArr = MyArray(created2dArray);
Show2dArray(changedArr);

