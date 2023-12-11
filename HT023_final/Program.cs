// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

static int AckermannRec(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannRec(m - 1, 1);
    else if (m > 0 && n > 0)
        return AckermannRec(m - 1, AckermannRec(m, n - 1));
    else
        return 0;
}

Console.WriteLine("Задайте значение неотрицательного числа m пределах от 0 до 3");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение неотрицательного числа n пределах от 0 до 4");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = AckermannRec(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");