// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите Второе число: ");
int b = int.Parse(Console.ReadLine()??"0");
int N = 10;


int Metod(int k, int m, int num)
{
    if (num == 1) return k;
    if (num == 2) return m;
    return Metod(k, m, num - 1) + Metod(k, m, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}

