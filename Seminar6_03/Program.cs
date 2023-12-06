// считать строку с консоли, состоящую из латинских букв в нижнем регистре 
// выяснить сколько среди введенных букв гласных

int GetCountVovelsInString(string str)
{
    string vovels = "aeiou"; 
    int count = 0;
    foreach(char elem in str)
    {
        foreach(char vol in vovels)
        {
            if(vol == elem)
            {
                count++;
            }
        }
    }
    return count;
}

string str = "Hello world";
int chars = GetCountVovelsInString(str);
Console.WriteLine ($"Vovels in {str} is {chars}");