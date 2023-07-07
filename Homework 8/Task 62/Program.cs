// Заполните спирально массив 4 на 4.

const int ROWS = 4;
const int COLUMNS = 4;

int[,] SpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0)-3; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =(i*4)+j+1;
        }
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 3; j == 3; j++)
        {
            matrix[i, j] = 4+i;
        }
    }
    for (int i = 3; i == 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrix[i, j] = 10-j;
        }
    }
    for (int i = 1; i < 3; i++)
    {
        for (int j = 0; j  == 0; j++)
        {
            matrix[i, j] = 13-i;
        }
    }
    for (int i = 1; i == 1; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            matrix[i, j] = 12+j;
        }
    }
    for (int i = 2; i == 2; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            matrix[i, j] = 17-j;
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

int[,] firstMatrix = SpiralMatrix(ROWS, COLUMNS);
PrintMatrix(firstMatrix);




