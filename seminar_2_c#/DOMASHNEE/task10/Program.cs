// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int b = a % 100;
int c = b / 10;
Console.WriteLine($"{a} -> {c}");