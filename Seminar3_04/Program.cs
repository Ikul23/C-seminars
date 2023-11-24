// Напишите программу которая выдает количество цифр в числе
void NumCount(int num){
    int count = 0;
    while(num>0){
        count++;
        num /= 10;
    }
    Console.WriteLine($"Sum of digits is {count}");
}

Console.WriteLine("Enter your num");
int num = Convert.ToInt32(Console.ReadLine());
NumCount(num);




//4 -> 24 
//5 -> 120

//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4