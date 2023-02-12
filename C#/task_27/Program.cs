// 27: Программа принимает на вход число и выдаёт сумму цифр в числе.

// ("Откалывание по-кусочкам от числа и прибавление (решить в методе))
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// 27: Программа принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"Сумма всех числел = {SumNumbers(num)}");

// Method 1 (Подсчет необходимого объема массива для размещения всех цифер, входящих в состав
// введенного числа)
int CountFigures(int number)
{
    byte index = 0;
    for (; number >= 1; index++)
    {
        number = number / 10;
    }
    return index;
}
// Method 2 (Суммирование всех чисел в массиве)
int SumNumbers(int Number)
{
    int[] Massiv = new int[CountFigures(num)];
    int Sum = 0;
    for(byte i = 0; i < Massiv.Length; i++ )
    {
    Massiv[i] = Number % 10;
    Number = Number / 10;
    Sum = Sum + Massiv[i];
    // Console.Write($"{Massiv[i]}, ");
    }
    return Sum;
}

