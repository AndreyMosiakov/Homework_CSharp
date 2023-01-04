// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число:");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int secondnumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
int thirdnumber = int.Parse(Console.ReadLine()!);

if (firstnumber > secondnumber)
{
    if (firstnumber > thirdnumber)
    {
        Console.WriteLine("Максимальное число: " + firstnumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdnumber);
    }
}

else if (secondnumber > thirdnumber)
{
    Console.WriteLine("Максимальное число: " + secondnumber);
}
else
{
Console.WriteLine("Максимальное число: " + thirdnumber);
}
