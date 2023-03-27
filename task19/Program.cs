// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("введите число M ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N ");
int number2 = Convert.ToInt32(Console.ReadLine());
SumNaturalElem(number1, number2);
void SumNaturalElem(int num1, int num2)
{
    Console.Write(SumNM(num1 - 1, num2));
}
int SumNM(int num1, int num2)
{
    int res = num1;
    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        res = num1 + SumNM(num1, num2);
        return res;
    }
}