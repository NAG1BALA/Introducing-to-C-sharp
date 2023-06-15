// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int midDigit = number / 10 % 10;
    // int midDigit = (number - number / 100 * 100) / 10;
    Console.WriteLine($"Исходное число {number}, Вторая цифра = {midDigit}");
}
else
{
    Console.WriteLine("Введенное число не удовлетворяет условию");
}