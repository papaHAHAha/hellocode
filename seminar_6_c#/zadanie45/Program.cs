/*Задача 45: Напишите программу,
которая будет создавать копию заданного массива
с помощью поэлементного копирования.*/
Console.Clear();
int[] GetArray(int minValue, int maxValue, int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(minValue, maxValue + 1);
  }
  return arr;
}
int[] CopyArr(int[] arr)
{
  int[] copy = new int[arr.Length];
  for(int i = 0; i < arr.Length;i++){
    copy[i] = arr[i];
  }
  return copy;
}
int[] Array = GetArray(0,10,10);
Console.WriteLine($"new array -> [{String.Join(", ", Array)}]");
int[] CopyArray = CopyArr(Array);
Console.WriteLine($"copy -> [{String.Join(", ", Array)}]");
