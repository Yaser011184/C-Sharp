/* Напишите программу, которая выводит случайноетрёхзначное число иудаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 ->98
*/

int GetRandomValue()
{
    return new Random().Next(100, 1000);
}

int DeleteSecondNumber( int number)
{
    return(number / 100) * 10 + (number % 10);
}

int number = GetRandomValue();
int result = DeleteSecondNumber(number);
Console.WriteLine($"Было {number}, стало {result}.");