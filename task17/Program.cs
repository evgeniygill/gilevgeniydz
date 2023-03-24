// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            { matrix[i, j, k] = UniqueValue(matrix, min, max, i, j, k); }
        }
    }
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k],4} ");
        }
        Console.WriteLine();
    }
}
int UniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    int Value;
    bool exist = true;
    Random rnd = new Random();
    bool _break = false;
    Value = rnd.Next(min, max + 1);
    while ((exist))
    {
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break)
                for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
                {
                    if (_break)
                        for (int k1 = 0; k1 < matrix.GetLength(2); k1++) ;
                }
            if (matrix[i, j, k] == Value)
            {
                _break = true;
            }
            if (i1 == i)
            {
                exist = false;
            }

        }
        return Value;
    }
}

int[,,] matrixd = CreateMatrix(2, 2, 2, 10, 99);
PrintArray(matrixd);
