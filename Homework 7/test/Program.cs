const int m = 3;
const int n = 4;

    double [,] matrix = new double[m, m];
    Random myRandom = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = myRandom.NextDouble()* ((10) - (-10)) + (-10);
        }

    }

 void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);