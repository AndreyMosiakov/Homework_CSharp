// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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
int GetDiffMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    int diff = max - min;
    return diff;
}
int[] array = GetArrayRandom(10, 1, 30);
showArray(array);
int diff = GetDiffMaxMin(array);
Console.WriteLine($" Разница между максимальным и минимальным элементами массива равна {diff}.");