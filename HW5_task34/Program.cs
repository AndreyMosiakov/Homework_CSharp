// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArrayRandom(int lenght, int strt, int end) // функция ввода рандомного массива
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(strt, end + 1);
    }
    return array;
}

void showArray(int[] array)  // функция для вывода массива , что бы после последнего символа не было запятой
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) // !=  -оператор не равно
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.WriteLine($"{array[i]}]");
        }
    }
}

int GetCountOfEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if(array[i]%2==0)
    {
      count += 1;  
    }
    return count;
}

int[] array = GetArrayRandom(15, 100, 999);
showArray(array);
int count = GetCountOfEvenNumber(array);
Console.WriteLine($" в данном массиве {count} четных чисел");