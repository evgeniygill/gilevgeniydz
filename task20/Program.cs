// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int number2 = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}
AkkermanFunction(number1, number2);
