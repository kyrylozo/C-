// Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите день недели в цифрах: ");
string stDay = Console.ReadLine();
int day = Convert.ToInt16(stDay);
int holiday1 = 6;
int holiday2 = 7;
int holiday3 = 2; // Допустим, у пользователя нестандартный выходной во вторник

if(day > 7 || day < 1)
{
    Console.WriteLine("Число должно соответствовать количеству дней в неделе!");
}
    else if (day == holiday1 || day == holiday2 || day == holiday3)
    {
        Console.WriteLine("Выходной");
    }
        else
        {
            Console.WriteLine("Рабочий день");
        }
