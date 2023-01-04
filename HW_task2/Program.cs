// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int secondnumber = int.Parse(Console.ReadLine()!);

if (firstnumber > secondnumber)
{
    Console.WriteLine($"Первое число {firstnumber} больше второго {secondnumber}");
}
else if(firstnumber < secondnumber)
{
     Console.WriteLine($"Второе число {secondnumber} больше первого {firstnumber}");
}
else
{
    Console.WriteLine($" чилсла {firstnumber} и {secondnumber} равны между собой");
}