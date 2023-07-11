// Console.Write("Введите значение M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int summa(int m, int n)
// {
// if (m==n)
// return n;
// else return m + summa(m + 1, n);
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");

int numberM = 4;
int numberN = 8;
int Perechislenie(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber) return firstNumber;
    else
    return firstNumber + Perechislenie(firstNumber + 1, lastNumber);  
}   
 Console.Write($"{Perechislenie(numberM, numberN)}");

