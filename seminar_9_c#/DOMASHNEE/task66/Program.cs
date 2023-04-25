/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
using System;
using static System.Console;
Clear();
Write("write m: ");
int m = int.Parse(ReadLine());
Write("write n: ");
int n = int.Parse(ReadLine());
WriteLine($"{sum(m, n)}");

int sum(int m, int n)
{
  if (m == n)
    return m;
  else
    m++;
  return sum(m,n) + m - 1;
}