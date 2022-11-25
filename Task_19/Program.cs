/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int Number = ReadInt("Введите пятизначное число: ");


int a = Number / 10000;
int b = (Number / 1000) % 10;
int d = Number % 10;
int c = ((Number % 100) - d) / 10;

if ( a == d && b == c)
{
Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не является Полиндромом");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
