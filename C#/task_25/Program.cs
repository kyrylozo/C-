// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// (методом цикла for, где получаем А и Б (без метода  Math.Pow()))

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// ==============================================================
// int[]Get_AB()
// {
//     int[] Array = new int[2];
//     Console.Write("Enter the 1st number: ");
//     Array[0] = int.Parse(Console.ReadLine());
//     Console.Write("Enter the 2d number: ");
//     Array[1] = int.Parse(Console.ReadLine());
//     return Array;
    
// }
// Console.Write(String.Join(", ", Get_AB()));
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
  