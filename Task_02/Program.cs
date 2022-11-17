// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Большое из двух чисел это: ");
if(numberOne > numberTwo)
{
Console.WriteLine(numberOne);
}
else
{
Console.WriteLine(numberTwo);
}
