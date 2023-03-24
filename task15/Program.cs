// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int[] SumElemArr(int[,] matrix2)
{
    int siz = matrix2.GetLength(0);
    int[] arr = new int[siz];
    for (int k = 0; k < matrix2.GetLength(0); k++)
    {
        int sum = 0;
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            sum += matrix2[k, j];
        }
        arr[k] = sum;
    }
    return arr;
}
void PrintSmallerElem(int[] arr)
{
    int minPos = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        if (arr[minPos] > arr[j])
        {
            minPos = j;
        }
    }
    Console.WriteLine(minPos + 1 + " строка наименьшая сумма");
}
int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintArray(array2d);
int[] summa = SumElemArr(array2d);
PrintSmallerElem(summa);
