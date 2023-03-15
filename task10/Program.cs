// 1.Задайте массив вещественных чисел.
// 2.Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreatArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}
void PrintArrayS(double[] arr)
{
    Console.Write($"[ ");
    int count = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"] ");
}
double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    Console.WriteLine($"Максимальный элемент {max}");
    return max;
}
double MinElement(double[] arr)
{
    Console.Write($" ");
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    Console.WriteLine($"Минимальный элемент {min}");
    return min;
}

double[] creatArrRnd = (CreatArrayRndDouble(5, 1, 100));
PrintArrayS(creatArrRnd);
double maxelem = MaxElement(creatArrRnd);
double minelem = MinElement(creatArrRnd);
Console.WriteLine($"Разность между максимальным элементом и минимальным: {maxelem - minelem}");