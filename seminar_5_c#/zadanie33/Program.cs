/* **Задача 32:**Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)*/

int[] newRandomArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int[] InverseArray(int[] array)
{
  int[] result = new int[array.Length];
  for (int j = 0; j < result.Length; j++)
    result[j] = array[j];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] *= -1;
  }
  return array;
}
Console.Clear();
int[] StartArray = newRandomArray(6, -9, 10);
Console.WriteLine(String.Join(" ", StartArray));
Console.WriteLine(String.Join(" ", InverseArray(StartArray)));