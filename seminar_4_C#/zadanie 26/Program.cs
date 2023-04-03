// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("write number");
int a = int.Parse(Console.ReadLine());
int GetNumber(int a)
{
  int sum = 0;
  while (a > 0)
  {
    a /= 10;
    sum += 1;
  }
  return sum;
}
Console.WriteLine($"{a} -> {GetNumber(a)}");