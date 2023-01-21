/* Напишите программу которая на вход принимает два числа и проверяет 
является ли первое число квадратом второго .*/

Console.WriteLine("Введите первое число");
string numderStr1 = Console.ReadLine();
int a = Convert.ToInt32(numderStr1);

Console.WriteLine("Введите второе число");
string numderStr2 = Console.ReadLine();
int b = Convert.ToInt32(numderStr2);

int c = a / b;
int d = b / a;

if (c == b)
{
    Console.WriteLine("Число является квадратом");
}
else
{
    Console.WriteLine("Число не является квадратом");
}

