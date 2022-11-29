/*  Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
 */

 /*  Напишите программу которая выводит массив из 8 элеметнов, заполенный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]


int size = 8;
int[] numbers = new int [size];
for (int i =0; i<numbers.Length; i++)
{
    numbers[i] = new Random().Next(0,2);
    Console.Write(numbers[i] + " ");
} */
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt16(Console.ReadLine());
int[] numbers = new int [size];

for (int i =0; i<numbers.Length; i++)
{
    numbers[i] = new Random().Next(0,99);
}
WriteArray(numbers);

void WriteArray(int[] array)
{
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

