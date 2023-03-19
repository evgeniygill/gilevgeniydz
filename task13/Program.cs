﻿// 1.Задайте двумерный массив из целых чисел.
// 2.Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] MatrixNewRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
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
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}
double FindAverage(int[,] matrix)
{
    double middle = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        middle = sum / matrix.GetLength(0);
        middle = Math.Round(middle, 1);
        Console.Write($" {middle}; ");
    }
    return middle;
}
int[,] arrmatrix = MatrixNewRndInt(3, 4, 1, 10);
PrintMatrix(arrmatrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
double find = FindAverage(arrmatrix);