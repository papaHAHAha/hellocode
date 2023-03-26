Console.Clear();
Console.WriteLine("write first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("write second number");
int b = int.Parse(Console.ReadLine());
int max = a;

if (a > b)
{
  max = a;
  Console.WriteLine($"max number = {max}");
}
if (a < b)
{
  max = b;
  Console.WriteLine($"max number = {max}");
}