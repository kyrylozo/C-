// Принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа


Console.WriteLine("Введите число от 100 до 999");
string stNumber = Console.ReadLine();
int number = Convert.ToInt32(stNumber);
int min = 99;
int max = 1000;
if(min < number && number < max)
{
    int num = (number / 10) % 10;
    Console.Write ($"Вторая цифра из введенного числа = {num}  ");
}
    else 
    {
        Console.Write("Число должно иметь не больше и не меньше 3-х знаков!");
    }