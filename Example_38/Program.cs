/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);
}

int difference(int[] array)
{
    int dif = 0;
    int max = 0;
    int min = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];

    if (array[i] < min)
        {
            min = array[i];
        }

        dif = max - min;

    }
    return dif;
}
Console.WriteLine("Введите колличество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {difference(array)}");