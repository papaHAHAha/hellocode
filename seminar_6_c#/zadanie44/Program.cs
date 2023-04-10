// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// <aside>
// ❗ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих
Console.WriteLine("Write N");
int n = int.Parse(Console.ReadLine());
int[] Fib(int n)
{
  int[] arr = new int[n];
  arr[0] = 0;
  if (n >= 2)
  {
    arr[1] = 1;
  }
  else { return arr; }
  for (int i = 2; i < n; i++)
  {
    arr[i] = arr[i - 1] + arr[i - 2];
  }
  return arr;
}
Console.WriteLine($"[{String.Join(' ', Fib(n))}]");