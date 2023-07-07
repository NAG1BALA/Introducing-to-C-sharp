// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

const int ROWS = 2;
const int COLUMNS = 2;

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

int[,] firstMatrix = GetRandomMatrix(ROWS, COLUMNS);
Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);
int[,] secondMatrix = GetRandomMatrix(ROWS, COLUMNS);
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatrix);
int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS);


for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int k = 0; k < secondMatrix.GetLength(0); k++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            for (int z = 0; z < secondMatrix.GetLength(1); z++)
            {
                resultMatrix[i,j] = firstMatrix[i, j] * secondMatrix[i, j];
            }
        }
    }
}
Console.WriteLine("Произведение двух матриц");
PrintMatrix(resultMatrix);

