// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 

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

int[,] MatrizenTransponieren(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    int[,] MatrixT = new int[columnCount,rowCount];
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
        {
            MatrixT[j,i] = matrix[i,j];
        }
    return MatrixT;
}

int[,] MyMatrixNew = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(MyMatrixNew);
Console.WriteLine();
int[,] MatrixT = MatrizenTransponieren(MyMatrixNew);
PrintMatrix(MatrixT);