﻿int[] array = { 1, 12, 43, 4, 15, 56, 27, 38 };

int n = array.Length;
int find = 56;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}