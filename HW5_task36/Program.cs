// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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

int GetSumOfOddElem(int[] array)
{
    int sumodd = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sumodd = sumodd + array[i];
    }
    return sumodd;
}

int[] array = GetArrayRandom(10, -100, +100);
showArray(array);
int summa = GetSumOfOddElem(array);
Console.WriteLine($" Сумма элементов на нечётных позициях массива равна {summa}.");