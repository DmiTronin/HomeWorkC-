﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число от 1 до 7 обозначющее день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 5 ||n == 1 || n == 4 || n == 3 || n == 2)
{
Console.WriteLine("Будний день");
}
else if( n == 6 || n == 7)
{
Console.WriteLine("Выходной день");
}

