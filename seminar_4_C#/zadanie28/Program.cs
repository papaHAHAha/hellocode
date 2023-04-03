//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5
int GetSum(int n)
{
  int sum = 1;
  for (int i = 1; i <= n; i++)
    sum = sum * i; //<=> sum = sum + i
  return sum;
}

Console.Clear();
Console.Write("write number: ");
int n = int.Parse(Console.ReadLine());
int a = GetSum(n);
Console.WriteLine($"{n} -> {GetSum(n)} ");
