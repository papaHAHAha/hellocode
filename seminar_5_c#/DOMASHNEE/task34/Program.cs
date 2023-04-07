// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2
int[] newArray(int size)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(100, 999);
  }
  return res;
}
int GetEvenNumber (int[] array)
{
  int sum = 0;
  foreach(int item in array)
  {
    if(item % 2 == 0) sum++;
  }
  return sum;
}
Console.Clear();
int[] startArray = newArray(4);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"колво четных чисел в массиве = {GetEvenNumber(startArray)}");