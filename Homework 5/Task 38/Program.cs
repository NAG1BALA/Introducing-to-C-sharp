// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива. (не использовать стандартные функции/методы)
// [3 7 22 2 78] -> 76

int[] array = { 3, 7, 22, 2, 78 };

int MaxArray = array[1];
for (int i = 0; i < array.Length; i++)
if (array[i] > MaxArray)
{
    MaxArray = array[i];
}
Console.WriteLine($"Максимальный элемент массива = {MaxArray}");

int MinArray = array[1];
for (int i = 0; i < array.Length; i++)
if (array[i] < MinArray)
{
    MinArray = array[i];
}
Console.WriteLine($"Минимальный элемент массива = {MinArray}");
 
 int Result = MaxArray - MinArray;
 Console.WriteLine($"Разнциа между максимальным и минимальным элементов массива  = {Result}");
 
   