// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string getStrRange ( int start, int finish)
{
   if(start==finish) 
   {
    return start +" ";
   }
   return start +","+ getStrRange(start+1, finish);
}
void GetSumOfRange (int start, int finish, int summa)
{
    if (start > finish) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {summa}"); 
        return;
    }
    summa = summa + (start++);
    GetSumOfRange(start, finish, summa);
}

int userStartNumber = GetDataFromUser("введите значение M");
int userFinishNumber = GetDataFromUser("введите значение N");
string rage = getStrRange(userStartNumber, userFinishNumber);
Console.WriteLine(rage);
GetSumOfRange(userStartNumber, userFinishNumber, 0);