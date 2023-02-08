// Принимает на вход число А и выдает сумму чисел от 1 до А

Console.Write("Enter number A: ");
int numA = int.Parse(Console.ReadLine());
if(numA < 1) 
{
    Console.WriteLine("Число меньше 1");
}
else
{
int sum1 = 0;
int sum2 = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum1 += i; //+= работает как накопитель значений для  "sum1"
        sum2 = i + (i + 1);
    }
Console.WriteLine($" Метод sum1.             {sum1}");
Console.WriteLine($" Неправильный метод sum2 {sum2}");
}
