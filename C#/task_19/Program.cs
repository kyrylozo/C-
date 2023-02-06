// 19. Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначеное число: ");
int number = int.Parse(Console.ReadLine());

double first = number % 10 * 10000;
double second = number % 100 / 10 * 1000;
double third = number % 1000 / 100 * 100;
double forth = number % 10000 / 1000 * 10;
double fifth = number / 10000;

int oppNumber = Convert.ToInt32(first + second + third + forth + fifth);

if(number == oppNumber)
{
    Console.WriteLine($"Число {number} является полиндромным");
    Console.WriteLine(" ");
}
    else 
    {
        Console.WriteLine($"Число {number} не является полиндромом");
        Console.WriteLine(" ");
    }

Console.WriteLine("Определение обратного порядка числа:");
Console.WriteLine($"{first}");
Console.WriteLine($" {second}");
Console.WriteLine($"  {third}");
Console.WriteLine($"   {forth}");
Console.WriteLine($"    {fifth}");
Console.WriteLine($"{oppNumber} (число в обратном порядке)");
Console.WriteLine(" ");
