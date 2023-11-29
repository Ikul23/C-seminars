// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа.
//Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м. 
// Пример
// 456  =>  [6 5 4]781  =>  [1 8 7]
void Test(int num)
{
  int count = 0;
  int num1 = num;

  while (num1 != 0)
  {
    num1 = num1 / 10;
    count++;
  }
  int[] array = new int[count];

  for (int i = 0; i < count; i++)
  {
    array[i] = num % 10;
    num /= 10;
    Console.Write(array[i] + " ");
  }

}

Test(78134);