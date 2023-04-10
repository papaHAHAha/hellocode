// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("write number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} -> {BinaryNumber(a)}");
string BinaryNumber(int a)
{
  string res = "";
  string nums = "01";
  while (a > 0)
  {
    res = nums[a % 2] + res;
    a /=2;
  }
  return res;
}

