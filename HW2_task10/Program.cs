// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}
int SearchSecondDigit(int number)
{
    int digit12 = number / 10;// деление без остатка на 10, что бы убрать последнюю цифру
    int result = digit12 % 10; // деление c остаком , где остатком как раз будет второе число
    return result;
}
int randomNumber = GetNumberFromRange(100, 999);
int secondNumber = SearchSecondDigit(randomNumber);
Console.WriteLine($"Число {randomNumber} без первой и третьей цифры {secondNumber}"); 