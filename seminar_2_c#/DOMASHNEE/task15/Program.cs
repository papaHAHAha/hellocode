// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("write number of day: ");
int a = int.Parse(Console.ReadLine());
if (a == 6 || a == 7)
{
  Console.WriteLine($"день {a} -> выходной");
}
if (a > 0 && a <= 5)
{
  Console.WriteLine($"день {a} -> не выходной");
}
if (a < 0 || a > 7)
{
  Console.WriteLine("в неделе 7 дней");
  return;
}