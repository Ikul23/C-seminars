// Задача 1: Написать программу, которая на вход принимает два числа 
// и выдает какое число большее, а какое меньшее

int a = 0;
int b = 0;

if (a == b){
    Console.WriteLine($" Числа равны между собой!"); // проверка на равенство чисел 
}
if (a > b){
    Console.WriteLine($"max={a} min={b}");
}
else if(b > a){
    Console.WriteLine($"max={b} min={a}");
}
