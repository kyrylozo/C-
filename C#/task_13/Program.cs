// Выводит третью цифру заданного числа или сообщает,что третьей цифры нет.

Console.Write("Введите число: ");
string stNum = Console.ReadLine();
int num = Convert.ToInt32(stNum);

if(num * 0.01 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
    else
    {
        while(num > 999)
        {
        num = num / 10;
        }
            int num3 = num % 10;
            Console.WriteLine($"Третья цифра числа = {num3}");
    }

