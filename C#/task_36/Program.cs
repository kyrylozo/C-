// 36: Задает одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Massiv()
{
    int[] Array = new int[5];
    for(byte ix = 0; ix < 5; ix++)
    {
        Array[ix] = new Random().Next(1,21);
    }
    return Array;
}

int IrregCount()
{
    int[] Ar = new int [5];
    Ar = Massiv();
    Console.WriteLine(String.Join(", ", Ar));
    int Sum = 0;
    for(byte ix = 0; ix < 5; ix+=2)
    {
        Sum = Sum + Ar[ix];
    }
    return Sum;
}
System.Console.WriteLine($"Сумма всех нечетных чисел = {IrregCount()}");