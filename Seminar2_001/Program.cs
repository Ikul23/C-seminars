// Задача: на вход принимае трехзначное 
//число и удаляет вторую цифру из этого числа
int num = 456;
int first = num / 100;
int second = num % 100; // подставляем остаток деления на 10
//Console.WriteLine($"{first}{second}");
int result = first*10 + second;
Console.WriteLine($"{result}");