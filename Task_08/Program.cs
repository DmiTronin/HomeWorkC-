// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 2;
 while (a <= n)
 {
    Console.Write(a + "; ");
    a = a + 2;
 }
