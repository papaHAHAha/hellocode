// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает **последнюю** цифру этого числа.

//     456 -> 6

//     782 -> 2

//     918 -> 8
Console.Clear();
Console.WriteLine("write number");
int a = int.Parse(Console.ReadLine());
int b = a % 10;
Console.Write(b);

