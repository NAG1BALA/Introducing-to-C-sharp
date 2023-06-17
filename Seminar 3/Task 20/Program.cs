// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,10 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату первой точки по оси X");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату первой точки по оси Y");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси X");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси Y");
int y2 = Convert.ToInt32(Console.ReadLine());

// Math.Pow(x, 2) - возведение в квадрат
// Math.Sqrt(x) - извлечение квадратного корня

double skobX = Math.Pow(x1 - x2, 2);
double skobY = Math.Pow(y1 - y2, 2);
double result = Math.Sqrt(skobX + skobY);

Console.WriteLine("Расстояние между двумя точками = " + $"{result:f2}");