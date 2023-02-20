// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userStartNumber = GetDataFromUser("введите значение N");

string rage = getStrRange(userStartNumber, 1);
Console.WriteLine(rage);
string getStrRange ( int start, int finish)
{
   finish =1; 
   if(start==finish) 
   {
    return start +" ";
   }
   return start +","+ getStrRange(start-1, finish);

}