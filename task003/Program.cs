// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int startN = 1;
if(number > 0)
{
    while(startN <= number)
    {
    if(startN % 2 == 0)
    {
        Console.Write(startN + " ");
    }
        startN = startN + 1;
    }
}
else
{
    Console.WriteLine("Введите положительное число");
}
