// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 10);
    }
    return array;
}
int SumUneven = 0;
int[] array = GetRandomArray();
Console.WriteLine($"Массив\t[ {string.Join(", ", array)} ]");

 for (int i = 1; i < array.Length; i+=2)
 {
    SumUneven = SumUneven + array[i];
 }
 Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах. = {SumUneven}");
