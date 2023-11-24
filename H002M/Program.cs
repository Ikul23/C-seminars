// // Задача 2: Написать программу, которая на вход принимает три числа 
// и выдает максимальное из этих чисел 
// решение с учетом Классов и Методов как порттале GB
using System;

static class Answer {
    static void FindMax(int a, int b, int c)
    {
        if (a == b && b == c)
        {
            Console.WriteLine($"Числа равны `{a}`");
        }
        if (a > b && b > c)
        {
            Console.WriteLine($"Первое число `{a}` является максимальным");
        }
        else if (b > c && c > a)
        {
            Console.WriteLine($"Второе число `{b}` является максимальным");
        }
        else if (c > b && b > a)
        {
            Console.WriteLine($"Третье число `{c}` является максимальным");
        }
    }

    static void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            a = -5;
            b = 25;
            c = 0;
        }

        FindMax(a, b, c);
    }
}
