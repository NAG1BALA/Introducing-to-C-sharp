// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int MainDiagonal(int[,] matrix)
{
    int min = matrix.GetLength(0);
    int sum = 0;
    if (min > matrix.GetLength(1))
    {
        min = matrix.GetLength(1);
    }
    for (int i = 0; i < min; i++)
        {
           sum = sum + matrix[i, i]; 
        }
    return sum;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]}\t");  //  /t - символ табуляции, выравнивает
        }
        Console.WriteLine();
    }
}


int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
int summa = MainDiagonal(myMatrix);
Console.WriteLine($"Cумма элементов главной диагонали {summa}");
