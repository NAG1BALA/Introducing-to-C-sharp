// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Введите первое число");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}