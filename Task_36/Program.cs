/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int result = 0;

FillArrayRandomNumbers(numbers, 1, 99);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
if (numbers[i] % 2 >= 1)
result+=numbers[i];
}
Console.WriteLine($"Сумма нечетных элементов массива составит: {result}");


void FillArrayRandomNumbers(int[] array, int min, int max)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1);
}
}

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}