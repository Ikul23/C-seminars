//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
string FilterString(string str){
    string res = str.ToLower();
    string count = "";
    foreach(char elem in res){
        if(elem != ' '){
            count+=elem;
        }
    }
    return count;
}

string IsPalindrome(string str){
    for(int i = 0; i<str.Length/2; i++){
        if(str[i] != str[str.Length-i-1]){
            return("String is not palindrome");
        }
    }
    return("String is palindrome");
}


string str = "ротор";
string res = FilterString(str);
Console.WriteLine(IsPalindrome(res));