/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3⁵)

2, 4 -> 16 
*/
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
/*
int count = 1;
while(count <=  b )
{
    result *= a;
    count++;
}
Console.WriteLine($"Результатом будет {result}");*/
for(int count = 1; count <= b; count++)
{
    result *= a;
}

Console.WriteLine($"Результатом будет {result}");
