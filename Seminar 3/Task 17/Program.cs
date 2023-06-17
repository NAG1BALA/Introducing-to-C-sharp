// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату по оси X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine(1);
}
else if (x < 0 && y > 0)
{
    Console.WriteLine(2);
}
else if (x < 0 && y < 0)
{
    Console.WriteLine(3);
}
else if (x > 0 && y < 0)
{
    Console.WriteLine(4);
}
else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}