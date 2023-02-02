/*
Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первы  й на последнем и т.д.)
1. инициализировать массив 
2. печатаем массив
3. переворачиваем массив
4. попробуем все решить в одну строчку
*/


int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1, 10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[] ReverseArray(int[] array)   // переворот массивва
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)   // i--  так как проходим массив с конца
    {
        result[count] = array[i];
        count++;
    }

    return result;
}


int[] startArray = InitArray(10);  // 10 это объем массива
PrintArray(startArray);
Console.WriteLine();

int[] resultArray = ReverseArray(startArray);
Console.WriteLine();
PrintArray(resultArray);

// 4 пункт (решение в одну строчку)

int[] arrStart = Enumerable.Range(1, 10).ToArray();

int[] arr = Enumerable.Range(1, 10).Reverse().ToArray();

Array.Reverse(arr);

arr.Reverse();   //это все методы для реврса массива