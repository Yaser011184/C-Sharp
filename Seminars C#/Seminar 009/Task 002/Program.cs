/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

string Recursiya(int m, int n)
{
    if (m <= n) return $"{m}, " + Recursiya(m + 1, n);
    else return string.Empty;
    
    
}

int m = GetNumber("Введите число:");
int n = GetNumber("Введите число:");
Console.WriteLine(Recursiya(m, n));
