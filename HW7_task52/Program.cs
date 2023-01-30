// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//int GetDataFromUser(string messege)
//{
//   Console.ForegroundColor = ConsoleColor.DarkGreen;
//  Console.WriteLine(messege);
//  Console.ResetColor();
//  int result = int.Parse(Console.ReadLine());
// return result;
//}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

int[,] Get2DIntArray(int colLength, int rowLenght, int start, int end)
{
    int[,] array = new int[colLength, rowLenght];

    for (int i = 0; i < colLength; i++)
    {

        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}
void print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); // знак табуляции , что бы всё выстроилось с правильными отступами
        }
        Console.WriteLine();
    }

}
double GetAruthmeticMeanOfRow(int[,] array)
{
    double avg = 0;
    double sumofcolumn =0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        for (int i = 0; i < array.GetLength(0);)
        {
            sumofcolumn = (sumofcolumn + array[i, j]);
            avg = sumofcolumn / array.GetLength(1)+1;
            i++;
        }  
    }
    return avg;
}

//int n = GetDataFromUser("введите количество строк");
//int m = GetDataFromUser("введите количество столбцов");
int[,] array = Get2DIntArray(3, 4, 0, 10);
print2DArray(array);
Console.WriteLine();
double avg = GetAruthmeticMeanOfRow(array);
Console.WriteLine(avg + ",");

