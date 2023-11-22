// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
//487 => 8^7 = 2 097 152
//254 => 5^4 = 625
//617 => 1
// int num = 254;

// int second = (num / 10) % 10;
// int power = num % 10;

// int count = 0;
// int result = 1;

// while (count < power) {
//     result = second * result;
//     count++;
// }

// Console.WriteLine(result);

int num = 254;

int second = (num / 10) % 10;
int power = num % 10;

double result = Math.Pow(second, power);

Console.WriteLine(result);

