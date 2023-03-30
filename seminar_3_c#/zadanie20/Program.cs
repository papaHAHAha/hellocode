// (x1-x2)^2+(y1-y2)^2
// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);
Console.Clear();
Console.WriteLine("write A");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("write B");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("write A1");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("write B1");
double b1 = double.Parse(Console.ReadLine());
double sqrt = Math.Sqrt((a - a1) * (a - a1) + (b - b1) * (b - b1));
Console.WriteLine($"{sqrt:f3}");