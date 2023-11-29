//Найдите произведения пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.
//Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int [] CreateArray(int min, int max, int size){

    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}

void ShowArray(int [] array){
    
    for(int i = 0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int[] CreateNewArray(int[] array)
{
  int[] result = new int[array.Length / 2 + array.Length % 2];
  int length = array.Length / 2;
  for (int i = 0; i < length; i++)
  {
    result[i] = array[i] * array[array.Length - i - 1];
  }
  if (array.Length % 2 > 0)
  {
    result[length] = array[length];
  }
  return result;
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(max, min, size);
ShowArray(arr);
int[] newArr = CreateNewArray(arr);
ShowArray(newArr);