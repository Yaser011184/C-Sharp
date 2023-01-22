/* Напишите программу, которая принимает на вход два числа и проверяет является ли одно число квадратом второго.
*/

int GetNumber()
{   Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();

if(firstNumber * firstNumber == secondNumber || 
secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine(" Является ");
}
else
{
    Console.WriteLine(" Не является ");
}