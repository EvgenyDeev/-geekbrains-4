/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101);
}

int MaxNumbers(int[] array)
{
    int max = 1;
    for (int i = 2; i < array.Length; i++)
    {
        if(array[i] > array[max])
         max = i;
         return max;
    }
}

int MinNumbers(int[] array)
{
    int min = 1;
    for (int i = 2; i < array.Length; i++)
    {
        if(array[i] < array[min])
         min = i;
         return min;
    }
}

Console.WriteLine("Введите колличество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
//Console.WriteLine($"Разницу между максимальным и минимальным элементом массива будет равна: {difference}");

 /*write(array[max], "-", array[min], "=", array[max] - array[min]);
 if (array[i] < array[min])
         min = i; */