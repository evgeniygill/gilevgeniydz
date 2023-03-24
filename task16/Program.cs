// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}
int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}
void PrintArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}
bool Matrixcheck(int[,] matrix, int[,] matrix2)
{
    if (matrix2.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] MultiplicMatrix(int[,] matrix, int[,] matrix2)
{
    int Rows = matrix.GetLength(0);
    int Cols = matrix.GetLength(1);
    int Rows1 = matrix2.GetLength(0);
    int Cols1 = matrix2.GetLength(1);
    int[,] result = new int[Rows, Cols1];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols1; j++)
        {
            for (int k = 0; k < Cols; k++)
            {
                result[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}
void PrintArray3(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}
int[,] array2d = CreateMatrixRndInt(2, 2, 0, 5);
PrintArray(array2d);
Console.WriteLine();
int[,] array3d = CreateMatrixRndInt2(2, 2, 1, 5);
PrintArray2(array3d);
Console.WriteLine();
bool canMulMatrix = Matrixcheck(array2d, array3d);
if (canMulMatrix)
{
    int[,] multarr = MultiplicMatrix(array2d, array3d);
    PrintArray3(multarr);
}
else
{
    Console.WriteLine("матрицы нельзя перемножить");
}
