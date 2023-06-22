// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadInt()
{
    Console.WriteLine("Введите число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadInt();
}

for (int j = 0; j < array.Length; j++)
{
     int index = array[j];
     Console.WriteLine(index);
}



