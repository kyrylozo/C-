/*
Принимает на вход три числа и проверяет, может ли существовать треугольник 
со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
двух других сторон.
*/

Console.Write("Размер 1-й стороны: ");
byte A = byte.Parse(Console.ReadLine());

Console.Write("Размер 2-й стороны: ");
byte B = byte.Parse(Console.ReadLine());

Console.Write("Размер 3-й стороны: ");
byte C = byte.Parse(Console.ReadLine());

// ЭТОТ ВАРИАНТ ТОЖЕ РАБОТАЕТ
// if(a >= (b + c)
//     || b >= (a + c)
//     || c >= (a + b))
//     {
//         Console.WriteLine("Такого треугольника не может быть");
//     }
// else 
// {
//     Console.WriteLine("Треугольник может существовать");
// }

bool IsTriangle(byte a, byte b, byte c)
{
    return (((a + b) > c)
        && ((a + c) > b)
        && ((b + c) > a));
}
if (IsTriangle(A, B, C))
{
    System.Console.WriteLine("Can exist ");
}
else
{
    System.Console.WriteLine("Impossible ");
}
