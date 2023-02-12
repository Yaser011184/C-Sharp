/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


int Power(int a, int b)
{
    if (b == 1)
        return a;
    else
        return a * Power(a, b - 1);
}

int result = Power(5, 3);
Console.WriteLine(result);
