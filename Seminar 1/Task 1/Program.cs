// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine("Введите первое число");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Введите первое число");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

if (numberA * numberA == numberB)
{
    Console.WriteLine("Верно, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Неверно, первое число не является квадратом второго");
}