// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}
int DeleteSecondDigit(int number)
{
    int digit3 = number % 10;// деление с остатком на 10 где остатком как раз будет третья цифра числа
    int digit1 = number / 100; // деление без остатка на 100 где результатом как раз будет первая цифра числа
    int result = digit1 * 10 + digit3;
    return result;
}
int randomNumber = GetNumberFromRange(100, 999);
int numberWithoutSecond = DeleteSecondDigit(randomNumber);
Console.WriteLine($"Число {randomNumber} без второй цифры  {numberWithoutSecond}");
