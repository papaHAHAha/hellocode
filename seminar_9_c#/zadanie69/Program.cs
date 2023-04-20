/*
Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.*/
using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
Write("Введите степень числа: ");
int pow = int.Parse(ReadLine());

WriteLine($"{PowNumbers(number, pow)}");
int PowNumbers(int number, int pow)
{
  if (pow == 0)
    return 1;
  return PowNumbers(number, --pow) * number;
}
