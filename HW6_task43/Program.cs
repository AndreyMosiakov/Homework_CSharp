 //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double getUserValue(string message)
{
    Console.WriteLine(message);
    double result = Convert.ToInt32(Console.ReadLine()!);
    return result;
}

double GetPointOfIntrsectionX(double b1, double k1, double b2, double k2)
{
    
    double x = (b2 - b1) / (k1 - k2);
    //if ((k1 == k2) && (b1 == b2)|| (k1 == k2))
    //{
    //    Console.WriteLine("Прямые не пересекаются, либо совпадают, либо паралельны");
    //}
    //else
    //{
    //    ????
    //}

    return x; 
}
double GetPointOfIntrsectionY(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2* x + b2;
    return y; 
}

double userB1 = getUserValue("Введите B1");
double userK1 = getUserValue("Введите K1");
double userB2 = getUserValue("Введите B2");
double userK2 = getUserValue("Введите K2");
double X = GetPointOfIntrsectionX(userB1, userK1, userB2, userK2);
double Y = GetPointOfIntrsectionY(userB1, userK1, userB2, userK2);
Console.WriteLine($"Прямые пересекутся в точке с координатами X {X} , Y {Y}");