﻿// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’  или при вводе числа, 
// сумма цифр которого чётная.


bool EvenDigitSum(int num) // Функция для проверки четности суммы цифр числа
{
    int digitSum = 0;

    while (num != 0)
    {
        digitSum += num % 10;
        num /= 10;
    }
    return digitSum % 2 == 0;
}


Console.WriteLine("Введите целое число (для завершения введите 'q'):");

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "q") // Проверка на завершение программы (если введен символ 'q')
    {
        Console.WriteLine("Программа завершена, так как введен символ 'q'.");
        break;
    }

    if (int.TryParse(input, out int num)) // Проверка на корректный ввод целого числа
    {

        if (EvenDigitSum(num)) // Проверка на четность суммы цифр числа
        {
            Console.WriteLine("Программа завершена, так как сумма цифр числа четная.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
    }
}