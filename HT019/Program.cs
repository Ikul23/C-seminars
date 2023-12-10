// Задача 1: Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива.

static char[,] StringToCharArray(string str)
{
    char[,] chars = new char[1, str.Length]; 
    for (int i = 0; i < str.Length; i++)
    {
        chars[0, i] = str[i];
    }
    return chars;
}

static void ShowCharsArr(char[,] chars)
{
    for (int i = 0; i < chars.GetLength(1); i++)
    {
        Console.Write(chars[0, i] + " ");
    }
}
string str = "Hello world!";
char[,] charArray = StringToCharArray(str);
ShowCharsArr(charArray);
