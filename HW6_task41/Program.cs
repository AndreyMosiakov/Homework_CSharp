// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int[] GetArrayFromUser(string message) // запрос элементов массива у пользователя 
{
   Console.WriteLine(message);
   int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
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
int GetCountOfPositive(int[] array)
{   
    int count =0; 
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    return count;
}
int[] array = GetArrayFromUser("Введите элементы через пробел: ");
showArray(array);
int count=GetCountOfPositive(array);
Console.WriteLine($"Кол-во элементов > 0: {count}");