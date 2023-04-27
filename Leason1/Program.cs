// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int valueX = Prompt("Введите координату X > ");

int valueY = Prompt("Введите координату Y > ");

FindQuaterPlane(valueX, valueY);

int Prompt(string message)
{
    Console.Write(message);
    int coordNumber = int.Parse(Console.ReadLine());
    return coordNumber;
}

void FindQuaterPlane(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть");
    }

    if (x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }

    if (x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");
    }

    if (x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть");
    }
}