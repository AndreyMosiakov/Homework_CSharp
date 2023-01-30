//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
Console.WriteLine();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine());
    return result;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write(data);
    Console.ResetColor();
}

double[,] Get2DDoubleArray(int colLength, int rowLenght, int start, int end)
{
    double[,] array = new double[colLength, rowLenght];
    
    for (int i = 0; i < colLength; i++)
    {

        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(),2);// округлили хвостик до 2х знаков
            
        }
    }
    return array;
}    
void print2DArray(double[,] array)
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
int n = GetDataFromUser("введите количество строк");
int m = GetDataFromUser("введите количество столбцов");
double[,] array = Get2DDoubleArray(n, m, 0, 100);
print2DArray(array);
