// Принимает на вход число и выдает количество цифр в числе

Console.Write("Enter the number ");
double num = double.Parse(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе: {CountFigures(num)}");

// Method
double CountFigures(double number)
{
    byte index = 0;
    for (; number >= 1; index++)
    {
        number = number / 10;
    }
    return index;
}
