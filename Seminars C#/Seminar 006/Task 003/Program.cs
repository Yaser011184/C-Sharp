/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

string numberStr = "";

while (a > 0)
{
    numberStr = numberStr + a % 2;
    a = a / 2;
}

Console.WriteLine(new string(numberStr.Reverse().ToArray()));
