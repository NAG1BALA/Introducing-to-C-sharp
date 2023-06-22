// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ReadInt(string message)
{
    Console.WriteLine(message); 
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int power(int numberA, int numberB)
{
    int result = 1;
    for (int i =1; i <= numberB; i++)
    {
        result*=numberA;;
    }
    return result;
    
}
int numberA = ReadInt("Введите первое число");
int numberB = ReadInt("Введите второе число");
if (numberB < 0)
{
    Console.WriteLine("Данное число не может быть больше нуля");
}
else
Console.WriteLine($"Число {numberA} в натуральной степени {numberB} равняется {power(numberA, numberB)}");






