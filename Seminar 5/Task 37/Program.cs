// Найдите произведение пары чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] numbers = { 1, 2, 3, 4, 5 };
int[] number2 = new int[(numbers.Length + 1) / 2];

for (int i = 0; i < number2.Length; i++)
{
    number2[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
if (numbers.Length % 2 != 0)
{
    number2[number2.Length - 1] = numbers[numbers.Length / 2];
}

Console.WriteLine($"[ {string.Join(", ", number2)} ]");
