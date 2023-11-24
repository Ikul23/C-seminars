// Вывести все четные числа в промежутке заданным пользователем, используя возвратную функцию


int TestFunc(int first){
    if (first%2==0){
        return first;
    }
    else{
        return 0;
    }
}

Console.WriteLine("enter first number");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int second_number = Convert.ToInt32(Console.ReadLine());

if(first_number>second_number){
    int temp = first_number;
    first_number = second_number;
    second_number = temp;
}

while(second_number>=first_number){
    int res = TestFunc(first_number);
    if(res !=0){ // != - означает 'не ноль'
        Console.Write($"{res}");
    }    
    first_number++;
}