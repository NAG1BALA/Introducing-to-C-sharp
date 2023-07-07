// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

const int ROWS = 2;
const int COLUMNS = 2;
const int SPACE = 2;

int[,,] GetRandomMatrix(int rows, int columns, int space)
{
    int[,,] matrix = new int[rows, columns, space];
    matrix[0, 0, 0] = 11;
    matrix[0, 0, 1] = 22;
    matrix[0, 1, 0] = 33;
    matrix[0, 1, 1] = 44;
    matrix[1, 0, 0] = 55;
    matrix[1, 0, 1] = 66;
    matrix[1, 1, 0] = 77;
    matrix[1, 1, 1] = 88;
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {

                Console.Write($"{matrix[i, j, k]} = {i}, {j}, {k} \t");
            }
        }
        Console.WriteLine();
    }
}

int[,,] myMatrix = GetRandomMatrix(ROWS, COLUMNS, SPACE);
Console.WriteLine(" Трехмерная матрица");
PrintMatrix(myMatrix);
