// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int QuaterPlane = Prompt("Введите четверть: ");
if (ValidQuaterPlane(QuaterPlane))
{
    FindQuaterPlane(QuaterPlane);
}

int Prompt(string message)
{
    Console.Write(message);
    int coordNumber = int.Parse(Console.ReadLine()!);
    return coordNumber;
}

bool ValidQuaterPlane(int x)
{
    if (x < 1 || x > 4)
    {
        Console.WriteLine("Число не является четвертью");
        return false;
    }
    return true;
}

void FindQuaterPlane(int x)
{
    if (x == 1)
    {
        Console.WriteLine(" X и Y от 0 до +бесконечноси");
    }
    if (x == 2)
    {
        Console.WriteLine(" X от -∞ до 0, Y от 0 до +∞");
    }
    if (x == 3)
    {
        Console.WriteLine(" X и Y от 0 до -∞");
    }
    if (x == 4)
    {
        Console.WriteLine(" X от 0 до +∞, Y от 0 до -∞");
    }

}
