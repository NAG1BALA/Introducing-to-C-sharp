// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
for (int i = -numberA; i <= numberA; i++)
{
    Console.WriteLine(i);
}