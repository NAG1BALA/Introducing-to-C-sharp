// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int ReadInt(string message)
// {
//     Console.WriteLine(message); 
//     return Convert.ToInt32(Console.ReadLine());
// }

int[] GetRandomArray(int length, int leftRandomRange, int rightRandomRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRandomRange, rightRandomRange + 1);
    }
    return array;
}

void ReverseArray(int[] sourceArray)
{
    for (int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i - 1];
        sourceArray[sourceArray.Length - i - 1] = temp;
    }
}

const int length = 5;   // int length = ReadInt("Введите число");
const int leftRandomBorder = -9;
const int rightRandomBorder = 10;
int[] myArray = GetRandomArray(length, leftRandomBorder, rightRandomBorder);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));