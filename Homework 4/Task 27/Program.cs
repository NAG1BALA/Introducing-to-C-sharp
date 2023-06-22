// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int sum(int number)
{
    int count = 0;
    while (number > 0)
    {
        count +=number % 10;
        number = number / 10;
    }
    return count;
}


int number = ReadInt();
int summa = sum(number);
Console.WriteLine($"Cумма цифр числа {number} равняется {summa}");
