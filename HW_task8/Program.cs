// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int numberone = 1;

while (numberone < number)
{
    if (numberone % 2 == 0)
    {
        Console.WriteLine($"Четные числа {numberone}+");
        numberone++;
    }
}