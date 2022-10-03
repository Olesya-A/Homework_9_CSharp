// 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int min = M;
int max = N;
if (N < M)
{
    min = N;
    max = M;
}

Console.Write(NumeralRow(min, max));

string NumeralRow(int min, int max)
{
    if (max == min) return $"{min}";
    else return NumeralRow(min, max - 1) + ", " + max;
}