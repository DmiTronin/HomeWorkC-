/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Repeat:
double  b1 = ReadInt("Введите значение b1: ");
double  k1 = ReadInt("Введите значение к1: "); 
double  b2 = ReadInt("Введите значение b2: ");
double  k2 = ReadInt("Введите значение к2: ");

if ( k1 == k2)
{
    Console.WriteLine("Такие пeременные не пересекаются");
    goto Repeat;
    
}


double x = -(b1-b2)/(k1-k2);
double y = k1 * x + b1;

Console.WriteLine($"Точкой пересечения двух прямых будет: {x}; {y}");


double ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
/* x= (b2-b1)/(k1*k2)
ищем y, если к1=к2 то нет точки пересечения*/