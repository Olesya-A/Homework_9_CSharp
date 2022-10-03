// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число неотрицательное целое M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число неотрицательное целое N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(Accerman(M, N));

int Accerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0) return Accerman(M - 1, 1);
    return Accerman(M - 1, Accerman(M, N - 1));
}