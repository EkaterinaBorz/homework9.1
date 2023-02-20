// Показать натуральные числа от N до 1, N задано

/*void PrintNumber(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumber(n - 1);
}
PrintNumber(5);
*/


Console.WriteLine();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
string NumbersRec(int a, int N)
{
  if (N <= a) return $"{a} " + NumbersRec(a - 1, N);
  else return String.Empty;
}
Console.WriteLine(NumbersRec(N, 1));

