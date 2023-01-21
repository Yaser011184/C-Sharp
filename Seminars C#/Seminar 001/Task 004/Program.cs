/* Напишите программу, которая на вход принимает одно число (назовём его n), 
а на выходе показывает все целые числа в промежутке от -n до n.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4 "
2 -> "-2, -1, 0 , 1 , 2 "
 */

Console.WriteLine("Введите первое число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = - number; i <=number; i++)
{
   Console.Write(i + " ,");
}
