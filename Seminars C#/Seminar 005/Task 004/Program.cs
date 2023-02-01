/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/


int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0,1000);
    }

    return arr;
}

int FidnCound(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100)
        count++;
    }
    return count;
}

int[] array = InitArray(123);
Console.WriteLine(string.Join(",", array));

int count = FidnCound(array);


Console.WriteLine($"-> В указанном массиве находится {count} двухзначных чисел.");
