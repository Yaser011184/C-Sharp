/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
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
            Console.WriteLine("Ввели некоретное число. Повторите ввод:");
        }
    }
    return result;
}

int Recurs(int m)
{
    if (m == 0)
        return 0;
    else
         return m % 10 + Recurs(m / 10);
           
}


int m = GetNumber("Введите число: ");
int sum = Recurs(m);
Console.WriteLine(sum);
