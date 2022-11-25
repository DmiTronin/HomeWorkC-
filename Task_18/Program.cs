// Напишите программу которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (х и у).
int quarter = ReadInt("ВВедите номер четверти: ");

switch (quarter)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Четвертей всего четыре");
        break;    
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}