// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4 \ 2*3 + 4*3 = 18 | 2*4 + 4*3 = 20
// 3 2 | 3 3 \ 3*3 + 2*3 = 15 | 3*4 + 2*3 = 18
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
using static System.Console;
Clear();
Write("Write rows first matrix: ");
int m1 = int.Parse(ReadLine());
Write("Write columns first matrix: ");
int n1 = int.Parse(ReadLine());
Write("Write rows second matrix: ");
int m2 = int.Parse(ReadLine());
Write("Write columns second matrix: ");
int n2 = int.Parse(ReadLine());

int[,] MatrixN1 = GetArray(m1, n1, 1, 5);
int[,] MatrixN2 = GetArray(m2, n2, 1, 5);
WriteLine("first matrix: ");
PrintArray(MatrixN1);
WriteLine("second matrix: ");
PrintArray(MatrixN2);
WriteLine();
if (n1 != m2)
{
  WriteLine("matrices cannot be multiplied");
}
else
{
  int[,] ResultMatrix = new int[n1, m2];
  MultiplyMatrix(MatrixN1, MatrixN2, ResultMatrix);
  PrintArray(ResultMatrix);
}
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
void MultiplyMatrix(int[,] MatrixN1, int[,] MatrixN2, int[,] ResultMatrix)
{
  for (int i = 0; i < ResultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
    {
      int multiply = 0;
      for(int n = 0; n<MatrixN1.GetLength(1); n++)
      {
        multiply += MatrixN1[i,n] * MatrixN2[n,j];
      }
      ResultMatrix[i,j] = multiply;
    }
  }
}