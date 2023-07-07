// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 145;

int Summa(int chislo)
{
    if (chislo <= 0) return 0;
    return
    Summa(chislo / 10) + (chislo % 10);
}

Console.Write(Summa(number));



// int ReadInt()
// {
//     Console.WriteLine("Введите число");
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int SummaAllDigital(int digital)
// {
//     int result = 0;
//     while (digital > 0)
//     {
//         result = result + digital % 10;
//         digital = digital / 10;
//     }
//     return result;
// }

// int digital = ReadInt();
// int SumDigital = SummaAllDigital(digital);
// Console.WriteLine($"Сумма чисел цифры {digital} будет равна - {SumDigital}");