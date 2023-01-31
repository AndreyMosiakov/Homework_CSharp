// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int GetDataFromUser(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(messege);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine());
    return result;
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
        //printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
void FindElementOfPosition(int[,] array, int number1, int number2)
{
    int element = array[number1, number2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] = array[number1, number2]);
            {
                element = array[i, j];
            }       
        }
        
    }
    return element;
}


int number1=GetDataFromUser("введите позицию элемента в строке");
int number2=GetDataFromUser("введите позицию элемента в столбце");
int [,] array = Get2Darray(5,5,1,20 );
print2DArray(array);
Console.WriteLine();
int element = FindElementOfPosition(array,number1,number2);
Console.WriteLine ($" на заданной позиции {number1},{number2} находится элемент со значением {element}"); 