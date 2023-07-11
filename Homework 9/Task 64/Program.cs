// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 5;

void Perechislenie(int firstNumber)
{
    if (firstNumber <= 0) return;
    Console.Write(firstNumber + "  ");
    Perechislenie(firstNumber - 1);
}
Perechislenie(number);