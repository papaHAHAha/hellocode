/*1.Напишите программу, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго.

a = 25; b = 5->да
a = 2 b = 10->нет
a = 9; b = -3->да
a = -3 b = 9->нет*/
Console.Write("write numA");
int numA = int.Parse(Console.ReadLine());
Console.Write("write numB");
int numB = int.Parse(Console.ReadLine());
int sqr = numA * numA;

if (numB == sqr)
{
  Console.WriteLine("a квадрат b");
}
else
{
  Console.WriteLine("a не квадрат b");
}