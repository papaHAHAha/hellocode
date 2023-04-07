/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/
int[] newArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}
int FindElements(int[] array, int leftRange, int rightRange)
{
  int sum = 0;
  foreach (int item in array)
  {
    if(item >= leftRange && item <= rightRange) sum++;
  }
  return sum;
}
Console.Clear();
int[] startArray = newArray(123, 0, 200);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Кол-во элементов в отрезке [10;99] = {FindElements(startArray, 10, 99)}");

