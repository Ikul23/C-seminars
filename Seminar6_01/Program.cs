// 

string GetStringFromCharArray(char [] chars){  // метод выводы симовльного массива
    string res = "";
    foreach (char elem in chars){ // тождественен циклу for
        res += elem;
    }
    return res;
}

char [] chars = {'a','d','c','b'};
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);

