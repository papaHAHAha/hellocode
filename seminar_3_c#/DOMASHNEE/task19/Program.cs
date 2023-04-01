// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
int a1 = a / 10000;
int a1_1 = a / 1000;
int a2 = a1_1 % 10;
int y_1 = a % 100;
int y1 = y_1 / 10;
int y2 = a % 10;
if (a1 == y2 && a2 == y1)
{
  Console.WriteLine($"{a} -> да");
}
else
{
  Console.WriteLine($"{a} -> нет");
}