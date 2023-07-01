// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

const int ROWS = 3;
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

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);

double delitel = 3.0;
double sum1 = (myMatrix[0, 0] + myMatrix[1, 0] + myMatrix[2, 0]) / delitel;
double sum2 = (myMatrix[0, 1] + myMatrix[1, 1] + myMatrix[2, 1]) / delitel;
double sum3 = (myMatrix[0, 2] + myMatrix[1, 2] + myMatrix[2, 2]) / delitel;
double sum4 = (myMatrix[0, 3] + myMatrix[1, 3] + myMatrix[2, 3]) / decimalelitel;

Console.WriteLine($"Среднее арифметическое каждого столбца {sum1:f1}, {sum2:f1}, {sum3:f1}, {sum4:f1}");
