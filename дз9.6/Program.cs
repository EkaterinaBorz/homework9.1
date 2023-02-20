// Написать программу вычисления функции Аккермана

Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n > 0 && m == 0)
    {
        return A(n - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return A(n - 1, A(n, m - 1));
    }
    return A(n, m);
}
Console.WriteLine($"Значение функции Аккермана = {A(n, m)}");