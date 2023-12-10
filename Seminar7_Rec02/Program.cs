// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

void NaturNum(int n)
{
    if (n > 0)
    {
        NaturNum(n - 1);
        Console.Write(n + " ");
    }
    else if (n < 0)
    {
        Console.WriteLine("Numb must be graiter then 0");
    }
}

NaturNum(-5);