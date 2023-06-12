// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Введите второе число");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);
Console.WriteLine("Введите третье число");
string c = Console.ReadLine();
int numberC = Convert.ToInt32(c);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);