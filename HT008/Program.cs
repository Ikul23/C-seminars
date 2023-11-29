 // Условие задачи: программа на вход принимает целое число N 
// а на выходе показывает его цифры через запятую

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
DigitsFunc(num);

void DigitsFunc(int num)
{
        Console.Write("Цифры числа: ");
        
        while (num > 0)
        {
            int digit = num % 10;
            Console.Write($"{digit}, ");
            num /= 10; 
        }
             
}