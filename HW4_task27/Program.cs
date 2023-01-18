// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int getUserNumber(string message)  // `функция получения информации от пользователя
{
    Console.WriteLine(message);
    int userNumber = int.Parse(Console.ReadLine()!);
    return userNumber;
}
int getSumOfDigit(int userNumber)
{
    int sum = 0;
    while (userNumber > 0)
    {
        sum = sum + userNumber % 10;
        userNumber = userNumber / 10;
    }
    return sum;
}

int userNumber = getUserNumber("Введите число ");
int sum = getSumOfDigit(userNumber);
Console.WriteLine($"В числе {userNumber} сумма цифр составляет {sum}");