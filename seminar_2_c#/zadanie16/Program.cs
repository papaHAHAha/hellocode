// 16 Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.WriteLine("Write first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write first number");
int b = int.Parse(Console.ReadLine());
if(Math.Pow(a, 2)== b ||Math.Pow(b, 2)== a )
{
  Console.Write("yes");
}
else
{
  Console.WriteLine("no");
}