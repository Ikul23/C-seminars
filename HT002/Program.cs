// Задача 2: Написать программу, которая на вход принимает три числа 
// и выдает максимальное из этих чисел
int a = 35;
int b = 200;
int c = -5;

if (a==b && b==c){
   Console.WriteLine($" Max = {a}"); // проверка на равенство чисел 
}
else if (a > b){
   Console.WriteLine($" Max a = {a}"); 
} 

else if (b > c){
   Console.WriteLine($" Max b = {b}"); 
} 
else if (c > a){
   Console.WriteLine($" Max c = {c}"); 
} 