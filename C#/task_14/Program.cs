// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.WriteLine("Enter number");
string stringnumber = Console.ReadLine();
int number = Convert.ToInt32(stringnumber);

if (number % 7 > 0)
{
        int result7 = number % 7;
        Console.WriteLine($"Не кратное. Остаток при делении на 7 = {result7}");
}
    else if (number % 23 > 0)
    {
        int result23 = number % 23;
        Console.WriteLine($"Не кратное. Остаток при делении на 23 = {result23}");
    }
        else
        {
            Console.WriteLine("Число кратно 7 и 23");
        }



