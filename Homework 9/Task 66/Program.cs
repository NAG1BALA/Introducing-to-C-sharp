// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = 4;
int numberN = 8;
int Perechislenie(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber) return firstNumber;
    else
    return firstNumber + Perechislenie(firstNumber + 1, lastNumber);  
}   
 Console.Write($"{Perechislenie(numberM, numberN)}");
