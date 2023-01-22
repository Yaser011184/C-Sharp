/* напишите программу, которая принимает на вход число и проверяет кратное ли оно одновременно 7 и 23. */

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите число");
int number = GetNumber();

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно");
}