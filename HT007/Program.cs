 // Условие задачи: программа на вход принимает целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа
    
    Console.WriteLine("Введите целое число от 10 до 99");
    int num = Convert.ToInt32(Console.ReadLine());
    MaxNumber(num);

void MaxNumber(int num)
{
        if (num >= 10 && num <= 99)
        {
            int max_dig = num % 10;
            int max_dig1 = num / 10;

            if (max_dig > max_dig1)
            {
                Console.WriteLine($"Наибольшая цифра в числе {num} - {max_dig}");
            }
            else
            {
                Console.WriteLine($"Наибольшая цифра в числе {num} - {max_dig1}");
            }
        }
        else
        {
            Console.WriteLine("Число не попадает в границы отрезка от 10 до 99, или не является целым");
        }
    }

