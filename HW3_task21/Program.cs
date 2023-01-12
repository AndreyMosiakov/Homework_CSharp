// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
double getDistanceCoordinate(int userAx, int userAy, int userAz, int userBx, int userBy, int userBz)
{
    double result = Math.Sqrt(Math.Pow((userAx - userBx), 2) + Math.Pow((userAy - userBy), 2) + Math.Pow((userAz - userBz), 2));  // формула вычисления
    return result;
}

int userAx = getUserValue("Введите X");
int userAy = getUserValue("Введите Y");
int userAz = getUserValue("Введите Z");

int userBx = getUserValue("Введите X");
int userBy = getUserValue("Введите Y");
int userBz = getUserValue("Введите Z");


double distance = getDistanceCoordinate(userAx, userAy, userBx, userBy, userAz, userBz);
Console.WriteLine($"Расстояние между точками {distance}");
