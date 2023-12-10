// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d 

void ShowConsonants(string s){
    if (s.Length == 0) return;
    string upper = "bcdfghjklmnpqrstvwxz";
    if(upper.Contains(char.ToLower(s[0]))){
        Console.Write(s[0]+" ");
    }
    ShowConsonants(s.Substring(1));
}

ShowConsonants("world");