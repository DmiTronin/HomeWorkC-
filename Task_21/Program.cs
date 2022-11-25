/* Напишите программу которая ппринимает на вход координаты двух точек и находит расстояние меджду ними в 2D пространстве.
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int aX = ReadInt("Введите координату X точки A: ");
int aY = ReadInt("Введите координату Y точки A: ");
int aZ = ReadInt("Введите координату Z точки A: ");
int bX = ReadInt("Введите координату X точки В: ");
int bY = ReadInt("Введите координату Y точки В: ");
int bZ = ReadInt("Введите координату Z точки В: ");

int sqrSideX = (aX - bX) * (aX -bX);
int sqrSideY = (aY - bY) * (aY -bY);
int sqrSideZ = (aZ - bZ) * (aZ -bZ);

double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}