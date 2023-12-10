// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string ConvertToUpperToLower(string original)
{
    return original.ToLower();
}
string originalString = "Hello World!";
string modifiedString = ConvertToUpperToLower(originalString);

Console.WriteLine("Original String: " + originalString);
Console.WriteLine("Modified String: " + modifiedString);