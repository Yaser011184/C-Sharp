/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0,10);
    }

    return arr;
}


int [] MultiOfNumbers(int[] array)
{
    bool chetniy = true;
    int [] newArray = null;
    if (array.Length % 2 == 0)
        newArray = new int [array.Length / 2];
    else
        {
        newArray = new int [array.Length / 2 + 1];
        chetniy = false;
        }
    for (int i = 0; i < newArray.Length; i++)
    {
        if (!chetniy && i == newArray.Length - 1)
            newArray[i] = array[i];
        else
            newArray[i] = array[i] * array[array.Length - i - 1];
    }   
    return newArray;
}


int[] array = InitArray(5);
Console.WriteLine(string.Join(",", array));

int [] newArray = MultiOfNumbers(array);
Console.WriteLine(string.Join(",", newArray));
