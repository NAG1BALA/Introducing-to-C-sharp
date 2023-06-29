// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadDouble(string message)
{
    Console.WriteLine(message); 
    return Convert.ToDouble(Console.ReadLine());
}


double FindX(double b1, double b2, double k1, double k2)
{
double tochkaX = (b2 - b1) / (k1 - k2);
return tochkaX;
}

double FindY(double b1, double b2, double k1, double k2)
{
double tochkaY = k1 * (b2 - b1) / (k1 - k2) + b1;
return tochkaY;
}

double b1 = ReadDouble("Введите значение b1");
double b2 = ReadDouble("Введите значение b2");
double k1 = ReadDouble("Введите значение k1");
double k2 = ReadDouble("Введите значение k2");
double x = FindX(b1,b2,k1,k2);
double y = FindY(b1,b2,k1,k2);

Console.WriteLine($"Точки пересечения двух прямых = {x}, {y}");