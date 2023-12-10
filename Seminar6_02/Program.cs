// на основе символов строки (тип string) сформировать
// массив символов типа (char[]) вывести массив на экран

char [] StringToCharArray(string str){      // метод создания
    char [] chars = new char [str.Length];
    for (int i=0; i<str.Length; i++){
        chars[i] = str[i];
    }
    return chars;
}

void ShowCharsArr(char [] chars){   // метод вывода
    foreach(char elem in chars){
        Console.Write(elem+" ");
    }
}

string str = "Hello world!";
char [] chars = StringToCharArray(str);
ShowCharsArr(chars);
