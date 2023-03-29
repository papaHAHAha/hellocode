//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("write number");
int a = int.Parse(Console.ReadLine());
while (a > 999)
{
  a/= 10;
}
int b = a%10;
Console.WriteLine(b);
//  int b(int a){
//   while (a > 999)
//   {
//   a /= 10;
//   }
//   return a % 10;
//  }
// Console.WriteLine(b(a));