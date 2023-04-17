/*Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
 на пересечении которых расположен наименьший элемент.*/
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
WriteLine();
WriteLine("Min Element in array: {0}", MinElement(array));



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}
int MinElement(int[,] array)
{
  int MinElement = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (MinElement > array[i,j])
      {
        MinElement = array[i,j];
      }
    }
  }
  return MinElement;
}