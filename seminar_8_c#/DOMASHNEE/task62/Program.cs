// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;
int RowsColumns = 4;
int[,] SpiralArray = GetSpiralArray(RowsColumns);
WriteLine();
PrintArray(SpiralArray);



void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write(inArray[i, j] + "\t");
    }
    WriteLine();
  }
}

int[,] GetSpiralArray(int size)
{
  int[,] Spiral = new int[size, size];
  int i = 0;
  int j = 0;
  int number = 1;
  while (size != 0)
  {
    int count = 0;
    do
    {
      Spiral[i, j++] = number++;
    }
    while (++count < size - 1);
    for (count = 0; count < size - 1; count++)
    {
      Spiral[i++, j] = number++;
    }
    for (count = 0; count < size - 1; count++)
    {
      Spiral[i, j--] = number++;
    }
    for (count = 0; count < size - 1; count++)
    {
      Spiral[i--, j] = number++;
    }
    ++i;
    ++j;
    if (size < 2)
    {
      size = 0;
    }
    else
    {
      size -= 2;
    }
  }
  return Spiral;
}
