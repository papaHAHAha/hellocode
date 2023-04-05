Console.Clear();
Console.WriteLine("write first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("write second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}, {b} -> {Math.Pow(a, b)}");