/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/
int[] newArray(int size)
{
  int[] result = new int[size];
  for (int i = 1; i < size; i++)
  {
    result[i] = new Random().Next(1, 150);
  }
  return result;
}
int[] FindElements(int[] array, int sum)
{
  int sum = 0;
  for (int i = 0; i <array.Length; i++)
}


