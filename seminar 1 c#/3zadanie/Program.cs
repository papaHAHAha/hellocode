﻿/*3. Напишите программу, которая будет выдавать название 
дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница*/
Console.Write("Напишите номер дня: ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
  Console.Write("Понедельник");
}
if (a == 2)
{
  Console.Write("Вторник");
}
if (a == 3)
{
  Console.Write("Среда");
}
if (a == 4)
{
  Console.Write("Четверг");
}
if (a == 5)
{
  Console.Write("Пятница");
}
if (a == 6)
{
  Console.Write("Суббота");
}
if (a == 7)
{
  Console.Write("Воскресенье");
}
if (a > 7)
{
  Console.Write("В недели 7 дней");
}