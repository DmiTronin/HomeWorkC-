/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);
double result = 0;
double max = numbers[1];
double min = numbers[0];

for(int i = 0; i < numbers.Length; i++)
{
if(max < numbers[i])
max = numbers[i];

if(min > numbers[i])
min = numbers[i];
}

result = max - min;


Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(result);
void FillArrayRandomNumbers(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
int randomNumber = new Random().Next(100, 1000);
array[i] = Convert.ToDouble(randomNumber)/10;
}
}

void WriteArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + "| ");
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}