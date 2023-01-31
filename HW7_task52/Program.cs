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

int[,] Get2Darray(int rowlenght, int cowlenght, int start, int end)
{
    int[,] array = new int[rowlenght, cowlenght];

    for (int i = 0; i < rowlenght; i++)
    {

        for (int j = 0; j < cowlenght; j++)
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
void showArray(float[] array)  // функция для вывода массива , что бы после последнего символа не было запятой
{
    Console.Write($"среднее арифметическое каждого из столбцов равно[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) // !=  -оператор не равно
        {
            Console.Write($"{array[i]}, | ");
        }
        else
        {
            Console.WriteLine($"{array[i]}]");
        }
    }
}
float[] GetAverageOfRow(int[,] array)
{

    float[] avarageArray = new float[array.GetLength(1)];

    float summa = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);


    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            summa += array[i, j];
        }
        avarageArray[j] = summa / rows;
        summa = 0;
    }
    return avarageArray;
}

//int n = GetDataFromUser("введите количество строк");
//int m = GetDataFromUser("введите количество столбцов");
int[,] array = Get2Darray(3, 4, 0, 10);
print2DArray(array);
Console.WriteLine();
float[] arrayOfAverage = GetAverageOfRow(array);
showArray(arrayOfAverage);

