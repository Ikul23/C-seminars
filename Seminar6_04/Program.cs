//даны две строки S и S0. Найти количество вхождений (элементов) S0 в строку S

string str = "world";
string str1 = "hjhagsfgdytte";

int GetCountVovelsInString(string str, string str1)
{
    int count = 0;
    foreach (char elem in str)
    {
        foreach (char vol in str1)
        {
            if (vol == elem)
            {
                count++;
            }
        }
    }
    return count;
}

int chars = GetCountVovelsInString(str, str1);
Console.WriteLine($"Совпадений {str} в {str1} составляет {chars} символов");