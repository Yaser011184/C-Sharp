/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
456 -> 6
739 -> 9
918 -> 8
 */


Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
int b = a % 10;
Console.WriteLine(b);
