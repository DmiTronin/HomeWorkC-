// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное из трех чисел это: ");
if(numberOne < numberTwo)
{
    if (numberTwo > numberThree)
    {
        Console.WriteLine(numberTwo);
    }
}
if(numberTwo < numberOne)
{
    if (numberOne > numberThree)
    {
        Console.WriteLine(numberOne);   
    }
}
if(numberOne < numberThree)
{
    if (numberThree > numberTwo)
    {
        Console.WriteLine(numberThree);
    }
}