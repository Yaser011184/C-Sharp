/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
1. инициализировать массив
2. заполнить массив числами
3. поиск заданного числа
4. число, вывод массива, ответ
*/


// инициализируем массив и заполняем его числами

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

bool FindNumber(int find, int[] array)
{
    
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (find == array[i])
        {
            result = true;
            break;
        }
    }
    return result;
}


int[] array = InitArray(10);
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Что будем искать? ");

int find = Convert.ToInt32(Console.ReadLine());
bool a = FindNumber(find, array);

if (a)
Console.WriteLine("Элемент найден");
else
Console.WriteLine("Элемент не найден");