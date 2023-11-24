//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
    Console.WriteLine ("Enter number");
    int square = Convert.ToInt32(Console.ReadLine());
    SquareFunc(square);

void SquareFunc(int n)
{
    for (int i=1; i<=n; i++)
    {
    int square = i * i;
    Console.Write($"{square} ");
    }
}

    