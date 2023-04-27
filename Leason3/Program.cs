// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

double x1 = Prompt("Введите x1: ");
double y1 = Prompt("Введите y1: ");
double x2 = Prompt("Введите x2: ");
double y2 = Prompt("Введите y2: ");

double Prompt(string message)
{
    Console.Write(message);
    double coordNumber = double.Parse(Console.ReadLine()!);
    return coordNumber;
}
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) ),2) );