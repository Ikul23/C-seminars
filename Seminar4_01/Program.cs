// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

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

bool FindDigit(int [] array, int digit){
    //bool flag = false;
    for(int i = 0; i<array.Length; i++){
        if(array[i] == digit){
           return true; 
        }
    }
    return false;
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter search digit");
int digit = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
bool res = FindDigit(array, digit);
if(res == true){
    Console.WriteLine("ДА");
}
else{
    Console.WriteLine("Нет");
}