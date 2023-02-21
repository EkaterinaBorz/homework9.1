// Написать программу возведения числа А в целую стень B

int Numbers(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (Numbers(numberA, numberB - 1));
}

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите возводимую степень: ");
int numberB = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine($"Число {numberA} в степени {numberB} = {Numbers(numberA, numberB)}");