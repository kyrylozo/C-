// Принимает на вход координаты точки (X, Y), причем X не равен 0 и Y не равен 0 и выдает
// номер четверти плоскости, в которой находится эта точка

Console.Write("Enter number ");
int numX = int.Parse(Console.ReadLine());

Console.Write("Enter number ");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0 )
{
    Console.WriteLine("1 Section");
}

else if (numX < 0 && numY > 0 )
{
    Console.WriteLine("2 Section");
}

else if (numX < 0 && numY < 0 )
{
    Console.WriteLine("3 Section");
}

else if (numX > 0 && numY < 0 )
{
    Console.WriteLine("4 Section");
}