// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

Console.Write(SumOfNumbers(min, max));

int SumOfNumbers(int min, int max)
{
    if (max == min) return max;
    else return SumOfNumbers(min+1, max) + min;
}