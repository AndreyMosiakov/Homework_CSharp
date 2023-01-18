// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] GetArrayRandom(int lenght) // функция ввода рандомного массива
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(1, 100); // ограничил диапазон случайных чисел
    }
    return arr;
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
            Console.Write($"{array[i]}]");
        }
    }
}
int[] array = GetArrayRandom(8);
showArray(array);