// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int[] getArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}
int FindMax(int[] array)
{
  int max = array[1];
  foreach (int item in array)
  {
    if (item > max) max = item;
  }
  return max;
}
int FindMin(int[] array)
{
  int min = array[1];
  foreach(int item in array)
  {
  if (item < min) min = item;
  }
  return min;
}
Console.Clear();
int[] startArray = getArray(4, 1, 20);
Console.WriteLine($"[{String.Join(", ", startArray)}]";
Console.WriteLine($"MAX = {FindMax(startArray)}");
Console.WriteLine($"MIN = {FindMin(startArray)}");
Console.WriteLine($"разница между максимальным и минимальным = {FindMax(startArray) - FindMin(startArray)}");