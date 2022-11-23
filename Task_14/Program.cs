/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDivider = 7;
int secondDivider = 23;

if(number % firstDivider == 0 && number % secondDivider == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}