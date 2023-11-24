// Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.

void MultFunc (int n)
{
    int mult = 1;
    for (int i=1; i<=n; i++)
    {
    mult = mult*i;
    }
    Console.WriteLine(mult);
}
    Console.WriteLine ("Enter number");
    int mult = Convert.ToInt32(Console.ReadLine());
    MultFunc(mult);