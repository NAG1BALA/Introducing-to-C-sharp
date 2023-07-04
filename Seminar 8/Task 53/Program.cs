// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

const int ROWS = 4;
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]}\t");  
        }
        Console.WriteLine();
    }
}

void SwapFirstAndLastRows(int[,] array)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    for (int j = 0; j < columnCount; j++)
    {
        int temp = array [0, j];
        array[0,j] = array[rowCount - 1, j];
        array[rowCount - 1, j] = temp;
    }
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
SwapFirstAndLastRows(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);