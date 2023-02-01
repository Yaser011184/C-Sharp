/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
1. инициализируем массив
2. заполняем массив случайными числами
3. переворачиваем числа
4. принт массив
*/

// инициализируем массив

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }

    return arr;
}


void ConvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = InitArray(5);
Console.WriteLine(string.Join(",", array)); // вывести в консоль массив

ConvertArray(array);
Console.WriteLine(string.Join(",", array));
