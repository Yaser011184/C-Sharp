/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение(умножить) чисел от 1 до N.
4 -> 24
5 -> 120
*/

int GetNumber(string message)
{
    int number = 0;

    while (true)
    {
       Console.WriteLine(message);

       if (int.TryParse(Console.ReadLine(), out number) && number >= 1 )
       {
        break;
       } 
       else
       {
        Console.WriteLine("Ввели не число. Повторите ввод:");
       }
    }
    return number;
}

int GetSumm(int number)
{
    int sum = 1;

    for (int i = 1; i <= number; i++)
    {
        sum = sum * i; 
    }
    return sum;
}

 int multi = GetNumber("Введите число:");

int result = GetSumm(multi);
Console.WriteLine(result);
