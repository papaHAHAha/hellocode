// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int FindSumNumbers(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) sum++;
  }
  return sum;
}
int[] GetArrayFromString(string stringArray)
{
  string[] nums = stringArray.Split(" ");
  int[] res = new int[nums.Length];

  for (int i = 0; i < nums.Length; i++)
  {
    res[i] = int.Parse(nums[i]);
  }
  return res;
}
Console.Write("write numbers: ");
string a = Console.ReadLine();
int[] array = GetArrayFromString(a);
Console.WriteLine($"[{String.Join(", ",array)}] -> {FindSumNumbers(array)}");