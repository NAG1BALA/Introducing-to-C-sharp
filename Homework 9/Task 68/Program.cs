// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

int first = 2;
int last = 3;

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackerman(m - 1, 1);
    else 
        return Ackerman(m - 1, Ackerman(m, n - 1));
}
Console.WriteLine($"{Ackerman(first, last)}");