// Задача 4: Написать программу, которая на вход принимает число N 
// а на выходе показывает все четные числа от 1 до N
int a = 100;
int count = 1;

if (a == 0)
{
    Console.WriteLine($"Число {a} является нулем!"); // проверка на 0
}
{
     Console.Write($"Четные числа от 1 до {a}:");    
}
        while (count <= a)
    {
        if (count % 2 == 0)
        {
            {
                Console.Write($" {count}");
            }
            if (count < a - 1)
            {
                Console.Write(" ");
            }
        }
        count = count + 1;
    }


