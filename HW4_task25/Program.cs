// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetExponentOfNumber (int userA , int userB )
{
    int res = userA;
    for (int i = 1; i < userB; i++)
    {
        res = res*userA;
    }
    return res;
}
int userA = getUserValue("Введите число А");
int userB = getUserValue("Введите число B");
int res = GetExponentOfNumber(userA, userB);
Console.WriteLine($"Число {userA} в {userB} степени равно {res}.");