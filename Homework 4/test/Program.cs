
int ReadInt(string message)
{
    System.Console.WriteLine(message); 
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

bool Proverka(int numberB)
{
    if(numberB < 0)
    {
        System.Console.WriteLine("Данное число не может быть больше нуля");
        return false;
    }
    return true;
}

int numberA = ReadInt("Введите первое число");
int numberB = ReadInt("Введите второе число");
if (Proverka(numberB))
{
    Console.WriteLine($"Число {numberA} в натуральной степени {numberB} равняется {power(numberA, numberB)}");
}
