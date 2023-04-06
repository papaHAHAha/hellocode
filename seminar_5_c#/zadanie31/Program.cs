int[] getRandomArray(int size, int minValue, int maxValue)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

int[] SumPosNeg(int[] array)
{
  int [] result = new int [2];
  foreach (int el in array)
  {
    result[0] +=el>0 ? el:0;
    result[1] +=el<0 ? el:0;
  }
  return result;
}
int[] array = getRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int[] r = SumPosNeg(array);
Console.WriteLine($"Positive sum = {r[0]}, negative sum = {r[1] }");
Console.WriteLine($"[ {String.Join(", ", array)} ]");