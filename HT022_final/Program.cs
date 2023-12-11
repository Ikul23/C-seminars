// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

Console.WriteLine("Задайте значение натурального числа M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение натурального числа N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string NumbersRec(int m, int n)
{
    if (m<=n) return $"{m} " + NumbersRec(m+1, n);
    else return string.Empty; // выход из цикла рекурсии
}

Console.WriteLine(NumbersRec(M,N));