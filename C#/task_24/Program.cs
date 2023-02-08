// Принимает на вход число А и выдает сумму чисел от 1 до А

Console.Write("Enter number A: ");
int numA = int.Parse(Console.ReadLine());

if(numA < 1) 
{
    Console.WriteLine("Число меньше 1");
}
else
{
    int result = GetSum(numA);
    Console.WriteLine($" Метод вывода 1 {result}");
    
    Console.WriteLine($" Метод вывода 2 {GetSum(numA)}");
}

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i; //+= работает как накопитель значений для  "sum"
    }
    return sum;
}