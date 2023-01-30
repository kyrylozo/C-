//Напишите программу, которая на вход принимает число и выдает, является ли число четным 

Console.Write("Введите число для тестирования на четность ");
string stringNumber = Console.ReadLine();
int Number = Convert.ToInt32(stringNumber);
string Result = "нечетное";
if(Number % 2 == 0) Result = "четное";
Console.Write("Число ");
Console.WriteLine (Result);

