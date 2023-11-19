// Задача 1: Написать программу, которая на вход принимает два числа 
// и выдает какое число большее, а какое меньшее
using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 15;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}
