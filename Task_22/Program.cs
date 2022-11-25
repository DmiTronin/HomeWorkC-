//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

int number = ReadInt("Введите число N: ");
int i = 1;
while(i <= number)
{
    Console.Write(i*i + " ");
    i++;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}