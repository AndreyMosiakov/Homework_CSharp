// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов. 
Console.Clear();

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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); // знак табуляции , что бы всё выстроилось с правильными отступами
        }
        Console.WriteLine();
    }
}
void rowMinSumOfElements(int[,] array)
{
    int Row = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Row = Row + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow = sumRow + array[i, j];
        if (sumRow < Row)
        {
            Row = sumRow;
            minSumRow = i; 
        }
        sumRow = 0;
    }
    Console.Write($"строка с наименьшой суммой элементов: {minSumRow + 1} строка");
}
int[,] array = Get2Darray(5, 5, 1, 9);
print2DArray(array);
rowMinSumOfElements(array);