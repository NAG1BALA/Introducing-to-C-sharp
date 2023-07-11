// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = 5;

void Perechislenie(int LastNumber)
{
    if(LastNumber <= 0) return;
    Perechislenie(LastNumber - 1);
    Console.Write(LastNumber + "  ");
}
Perechislenie(number);