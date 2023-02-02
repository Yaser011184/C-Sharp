
/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/


int[] InitArray(int message)
{
    int[] result = new int[message];
    Random rnd = new Random();

    for (int i = 0; i < message; i++)
    {
        result[i] = rnd.Next(1, 10);
    }
    return result;
}

int[] CopyArray(int[] startArray)
{
    int[] array = new int[startArray.Length];

    for (int i = 0; i < startArray.Length; i++)
    {
        array[i] = startArray[i];
    }
       
    return array;
}


int[] array = InitArray(10);
Console.WriteLine(string.Join(", ", array));

int[] arr = CopyArray(array);
Console.WriteLine(string.Join(", ", arr));