/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
1. инициализация массива
2. печатаем массив
3. находим сумму отрицвтельных чисел в массиве
4. находим сумму положительных чисел в массиве
5*. сумма положительных и отрицательных чисел в один метод.
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

// печатаем массив

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]} "); 
    }

    Console.WriteLine();
}

// находим сумму положительных чисел в массиве

int GetPositiveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sum += array[i];
    }

    return sum;
}

// находим сумму отрицательных чисел в массиве

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        sum += array[i];
    }

    return sum;
}

(int, int) GetSumsFromArray(int[] array)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        posSum += array[i];
        else
        negSum += array[i];
    }
    return (posSum, negSum);
}

int[] array = InitArray(12);
PrintArray(array);
int posSum = GetPositiveSum(array);
int negSum = GetNegativeSum(array);


(int pos, int neg) = GetSumsFromArray(array);

Console.WriteLine($"сумма положительных чисел = {posSum}, \n сумма отрицательных чисел = {negSum}");

Console.WriteLine($"сумма положительных чисел = {pos}, \n сумма отрицательных чисел = {neg}");