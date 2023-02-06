// 21. Принимает на вход координаты 2 точек и находит расстояние между ними в 3D пространстве

Console.Write("1 точка Х: ");
int X1 = int.Parse(Console.ReadLine());

Console.Write("1 точка Y: ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("1 точка Z: ");
int Z1 = int.Parse(Console.ReadLine());


Console.Write("2 точка Х: ");
int X2 = int.Parse(Console.ReadLine());

Console.Write("2 точка Y: ");
int Y2 = int.Parse(Console.ReadLine());

Console.Write("2 точка Z: ");
int Z2 = int.Parse(Console.ReadLine());

double Distance2D = Math.Pow((Math.Pow((X2 - X1),2) + (Math.Pow((Y2 - Y1),2))),0.5);
double Distance3D = Math.Sqrt(Math.Pow((Distance2D),2) + (Math.Pow((Z2 - Z1),2)));

Console.WriteLine($"3D Distance between two points = {Math.Round(Distance3D,2)}");
//Console.WriteLine(Distance3D.ToString("c3"));
