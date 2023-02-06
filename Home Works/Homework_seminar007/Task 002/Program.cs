/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элемент 7
*/

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            
        }
        
    }
    
}

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {   
        Console.WriteLine(message);    
        if (int.TryParse(Console.ReadLine(), out result) && result >=0)
            {
                break;
            }
        else
            {
                Console.WriteLine("Ввели некоректное число. Повторите ввод:");
            }
    }
    return result;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}, ");
        }
        Console.WriteLine();
    }
}

 void ShowNumber(int[,] matrix, int num1, int num2)
 {
    if (num1 > matrix.GetLength(0) || num2 > matrix.GetLength(1))
        {
            Console.WriteLine("Такого элемента нет");
        }
    else
        {
            Console.WriteLine($"значение элемента {num1} строки и {num2} столбца = {matrix[num1 - 1, num2 - 1]}");
        }
 }


int num1 = GetNumber("введите первое число");
int num2 = GetNumber("введите второе число");

int[,] matrix = new int[num1, num2];

FillMatrix(matrix);
PrintMatrix(matrix);
ShowNumber(matrix, num1, num2);
