// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("third number");
int c = int.Parse(Console.ReadLine());
bool TriangleOrNo(int a, int b, int c)
{
  if (a + b > c && a + c > b && b + c > a)
  {
    return true;
  }
  return false;
}
if (TriangleOrNo(a, b, c))
{
  Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}
