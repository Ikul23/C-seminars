//Вывечти все четные числа в указанном диапазоне, используя невозвратную функцию

void TestFunc(int first) {
    if(first % 2 == 0) {
        Console.Write(first + " ");
    }
}

Console.WriteLine("enter first number");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int second_number = Convert.ToInt32(Console.ReadLine());

if(first_number > second_number) {
    int temp = first_number;
    first_number = second_number;
    second_number = temp;
}

while (second_number >= first_number) {
    TestFunc(first_number);
    first_number++;
}
