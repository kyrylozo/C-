// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// (методом цикла for, где получаем А и Б (без метода  Math.Pow()))

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// ==============================================================

//sbyte GetAB(sbyte num1, sbyte num2)
//{
//    sbyte[] Array = new sbyte[2];
//    Console.WriteLine("Enter the 1st number: ");
//    Array[0] = sbyte.Parse(Console.ReadLine());
//    Console.Write("Enter the 2d number: ");
//    Array[1] = sbyte.Parse(Console.ReadLine());
//    return Array;
//    Console.Write($"Entered numbers {Array[0]}, {Array[1]}");
//}
// ==============================================================

Console.Write("Enter the 1st number: ");
byte numA = byte.Parse(Console.ReadLine());
Console.Write("Enter the 2d number: ");
byte numB = byte.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine($"{numA} в степени {numB} = {Power(numA, numB)}");

//Method
int Power(int number1, int number2)
{
    int result = number1;
    for(byte i = 2; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}
  