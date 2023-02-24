/* 43. Находит точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1
y = k2 * x + b2
Значчения b1, k1 b2 и k2 задаются пользователем
*/


Console.Write("Enter k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Enter k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.Write("Enter b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Enter b2: ");
double b2 = double.Parse(Console.ReadLine());


double CrossX(double K1, double K2, double B1, double B2) //  Координата Х
{
    double x = (B2 - B1) / (K1 - K2);
    return x;
}
double CrossY(double K1, double K2, double B1, double B2) // Координата Y
{
    double y = (B2 - B1) / (K1 - K2) * K1 + B1;
    return y;
}

Console.WriteLine($"Координаты пересечения прямых: х = {CrossX(k1, k2, b1, b2)}, y = {CrossY(k1, k2, b1, b2)}");