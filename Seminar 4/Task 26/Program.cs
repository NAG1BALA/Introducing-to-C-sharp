// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt() 
{
    Console.WriteLine("Введите число");   
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Digits(int number)
{
    int count = 1;
    while (number >= 10)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int number = ReadInt();
int count = Digits(number);

Console.WriteLine($"{count} цифр в числе");
