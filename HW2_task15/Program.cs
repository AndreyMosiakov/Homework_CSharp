// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число обозначающее день недели от 1 до 7");
int num = int.Parse(Console.ReadLine()!);

if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine($"этот день {num} не является выходным");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine($"этот день {num} выходной");
}
else
{
    Console.WriteLine("Введите число обозначающее день недели от 1 до 7");
}

