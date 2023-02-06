// Принимает на воход число (N)  выдает таблицу кубов чисел от 1 до N


Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine());
byte ind = 1;
Console.WriteLine("Кубы чисел от 0 до указанного числа включительно: ");

while (ind <= N)
{
    Console.Write($"| {Math.Pow(ind,3)}");
    ind++;
}