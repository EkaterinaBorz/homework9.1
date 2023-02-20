// Показать натуральные числа от 1 до N, N задано

Console.WriteLine();
Console.WriteLine("Введите число от 1 до N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
string NumbersRec(int a, int N)
{
  if (a <= N) return $"{a} " + NumbersRec(a + 1, N);
  else return String.Empty;
}
Console.WriteLine(NumbersRec(1, N));
