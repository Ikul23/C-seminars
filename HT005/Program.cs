
 // Условие задачи: программа на вход принимает число и проверяет,
// кратно ли оно одновременно числам 7 и 23

       Console.WriteLine("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 7 == 0)
            {
                Console.WriteLine($"Число {number} кратно и 7 и не кратно 23");
            }
            else if(number % 23 == 0)
            {
                Console.WriteLine($"Число {number} кратно 23 и не кратно 7");
            }
            else
            {
                Console.WriteLine($"Число {number} не кратно и 7 и 23.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
        }
 
    
    
