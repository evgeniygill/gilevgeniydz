//  Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки ");
Console.Write("x: ");
int xPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int zPointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  координаты второй точки ");
Console.Write("x: ");
int xPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int zPointB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xPointA, yPointA, zPointA, xPointB, yPointB, zPointB);
Console.WriteLine($"Расстояние между точками равно :  {Math.Round(distance, 2, MidpointRounding.ToZero)}");

double Distance(int xA,int xB ,int yA,  int yB, int zA, int zB)
{
    return Math.Sqrt(Math.Pow(xA-xB, 2)+Math.Pow(yA-yB, 2)+Math.Pow(zA-zB, 2));
}