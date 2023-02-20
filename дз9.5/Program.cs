// Найти сумму цифр числа

Console.WriteLine();
int SumDigits(int number)
{
    if (number < 1) return 0;
    return SumDigits(number / 10) + number % 10;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine($"Сумма цифр числа = {SumDigits(number)}");