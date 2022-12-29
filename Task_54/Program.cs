/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементов каждой строки двумерного массива.
// Например, заданный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 23
*/
Console.WriteLine ($" \n Введите размер массива mxn: ");
int  m  =  ReadInt( " Введите m: " );
int  n  =  ReadInt( " Введите n: " );

int [,] array  =  new  int [ m , n ];
FillMatrixRandomNumbers ( array );
WriteArray ( array );

Console.WriteLine ( $" \n Отсортированный массив: " );

for(int k = 0; k < array.GetLength(0); k++)
{
for(int i = 0; i < array.GetLength(1); i++)
{
for(int j = 0; j < array.GetLength(1) - 1; j++)
{
if(array[i, j] < array[i, j + 1])
{
int temp = array[i, j];
array[i, j] = array[i, j + 1];
array[i, j + 1] = temp;
}
}
}
}
WriteArray ( array );




int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}

void WriteArray ( int [,] array )
{
  for ( int  i  =  0 ; i  <  array . GetLength ( 0 ); i ++ )
  {
    for ( int  j  =  0 ; j  <  array . GetLength ( 1 ); j ++ )
    {
       Console.Write ( array [ i , j ] +  "  " );
    }
    Console.WriteLine ();
  }
}