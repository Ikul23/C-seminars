// на вход А, сумма от 1 до А
void NunFunc(int first){
    int sum = 0;
    for(int i=1;i<=first;i++){
        sum+=i;
    }
    Console.WriteLine(sum);

}

Console.WriteLine("enter numb");
int num = Convert.ToInt32(Console.ReadLine());
NunFunc(num);