// Напишите программу, которая принимает на вход пятизначное число и проверяет, является лионо палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Данное число не является пятизначным");
}

int firstDigit = number / 10000;
int secondDigit = number / 1000 % 10;
int fourthDigit = number / 10 % 10;
int fifthDigit = number % 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
    Console.WriteLine("Данное пятизначное число является палиндромом");
}
else
{
    Console.WriteLine("Данное пятизначное число НЕ является палиндромом");
}