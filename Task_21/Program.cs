// Напишите программу которая ппринимает на вход координаты двух точек и находит расстояние меджду ними в 2D пространстве.

int aX = ReadInt("Введите координату X точки A: ");
int aY = ReadInt("Введите координату Y точки A: ");
int bX = ReadInt("Введите координату X точки A: ");
int bY = ReadInt("Введите координату Y точки A: ");

int sqrSideX = (aX - bX) * (aX -bX);
int sqrSideY = (aY - bY) * (aY -bY);
double distance = Math.Sqrt(sqrSideX + sqrSideY);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}