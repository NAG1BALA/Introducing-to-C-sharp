// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел(число), которое хотите ввести ");
int m = Convert.ToInt32(Console.ReadLine());

int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int count = 0;
int[] array = new int[m];
for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadInt();
    if (array[i] > 0)
    {
        count++;
    }
    Console.WriteLine($"Количество положительных чисел, которые Вы ввели = {count}");
}


