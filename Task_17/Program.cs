// Напишите программу, котроая принимает на вход координаты точки (X и Y), причем X != o и Y != 0 и выдает номер четверти плоскости, в котрой находится эта точка

int x = ReadInt("ВВедите точку x: ");
int y = ReadInt("ВВедите точку y: ");

if ( x == 0 || y == 0)
{
    Console.WriteLine("х и у не могут быть равны о");
    return;
}
if ( x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if ( x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if ( x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if ( x > 0 && y < 0)
{
    Console.WriteLine("4");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
