// 28. Принимает на вход число N и выдает произведение чисел от 1 до N

Console.Write("Enter the number ");
sbyte num = sbyte.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine($"Число должно быть больше 0");
}
    else
        {
             Console.WriteLine($"Факториал числа N = {Factorial(num)}"); 
        }

// Method
double Factorial(sbyte number)
{
    double factorial = 1;
    for (byte index = 1; number >= index; index++)
    {
        //factorial = factorial * index;
        factorial *= index;
    }
    return factorial;
}
