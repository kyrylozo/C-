// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Enter two numbers");
string stringnumberA = Console.ReadLine();
int numberA = Convert.ToInt32(stringnumberA);
string stringnumberB = Console.ReadLine();
int numberB = Convert.ToInt32(stringnumberB);
if (numberA % numberB == 0)
{
    Console.WriteLine("Кратное");
}
    else
    {
        int result = numberA % numberB;
        Console.WriteLine($"Не кратное. Остаток = {result}");
    }