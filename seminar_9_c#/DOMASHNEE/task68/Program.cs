﻿/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
using System;
using static System.Console;
Clear();
Write("write m: ");
int m = int.Parse(ReadLine());
Write("write n: ");
int n = int.Parse(ReadLine());
WriteLine($"{ackerman(m,n)}");

int ackerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if ((m > 0) && (n == 0))
  {
    return ackerman(m - 1, 1);
  }
  else if ((m > 0) && (n > 0)){
    return ackerman(m - 1, ackerman(m, n - 1));
  }
  return ackerman(m,n);
}