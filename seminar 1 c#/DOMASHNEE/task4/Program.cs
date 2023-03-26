Console.Clear();
Console.WriteLine("write first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("write second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("write third number");
int c = int.Parse(Console.ReadLine());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"max = {max}");
