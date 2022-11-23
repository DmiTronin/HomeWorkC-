/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет*/

int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите первое число: ");

if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}