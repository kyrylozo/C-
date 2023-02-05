// Принимает на вход координаты 2 точек и находит расстояние между ними в 2D пространстве

Console.Write("1 точка Х: ");
int X1 = int.Parse(Console.ReadLine());

Console.Write("1 точка Y: ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("2 точка Х: ");
int X2 = int.Parse(Console.ReadLine());

Console.Write("2 точка Y: ");
int Y2 = int.Parse(Console.ReadLine());

double Distance = Math.Pow((Math.Pow((X2 - X1),2) + (Math.Pow((Y2 - Y1),2))),0.5);

Console.WriteLine($"Distance between two points = {Distance}");