// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его чисел. С помощью рекурсии. Рекурсию начинаем с выхода!!!

int SumOfDigits(int num)
{
    if (num == 0) return num;
    int res = num%10 + SumOfDigits(num/10);
    return res;

}
int result = SumOfDigits(1006);
Console.WriteLine (result);
