int[] NewArray(int size)
{
  int[] count = new int[size];
for (int i = 0; i < size; i++){
  count[i] = new Random().Next(1, 999);
}
return count;
}
int[] array = NewArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
