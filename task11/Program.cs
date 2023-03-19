// //Задайте двумерный массив размером m×n,
// //заполненный случайными вещественными числами.
// // m = 3, n = 4.
// //   0     1    2     3
// // 0  0,5   7   -2   -0,2
// // 1  1   -3,3   8   -9,9
// // 2  8    7,8  -7,1  9

double[,] CreatMatrixrnd(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * 20 - 10;
            matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine();
    }
}
double[,] arrayM = CreatMatrixrnd(3, 4, 1, 100);
PrintMatrix(arrayM);
