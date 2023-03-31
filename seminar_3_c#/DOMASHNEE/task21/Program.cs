// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("write x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("write y");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("write z");
double z = double.Parse(Console.ReadLine());
Console.WriteLine("write x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("write y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("write z1");
double z1 = double.Parse(Console.ReadLine());
double sqrt = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1) + (z - z1) * (z - z1));
Console.WriteLine($"{sqrt:f2}");
