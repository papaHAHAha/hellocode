Console.Clear();
Console.WriteLine("write number");
int a = int.Parse(Console.ReadLine());
int n = a;
int sum = 0;
while(n>0){
  sum += n%10;
  n = n/10;
}
Console.WriteLine($"{a} -> {sum}");