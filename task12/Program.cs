// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет





Console.WriteLine("Введите размеры массива");
int r = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[r, c]; // 0, 1
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 20);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine();
}

{
    Console.WriteLine("Введите число a :");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b :");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a < 0 | a > matrix.GetLength(0) | b < 0 | b > matrix.GetLength(1))
        Console.WriteLine("такого элемента нет");
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[a, b]);
    }
}
