/* 
34.1: Задает параметры массива со случайными положительными числами 
и показывает количество чётных чисел в массиве.
*/

// Не корректно работает, если в массиве 2 одинаковых числа
// ===================================================
// Метод создания массива


Console.Write("Размер массива: ");
int sz = int.Parse(Console.ReadLine());

Console.Write("Минимальное значение в массиве: ");
int minVal = int.Parse(Console.ReadLine());

Console.Write("Максимальное значение в массиве: ");
int maxVal = int.Parse(Console.ReadLine());


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] Massiv = new int[size];
    for(int i = 0; i < size; i++)
    {
        Massiv[i] = new Random().Next(minValue, maxValue + 1);
    }
    return Massiv;
}
Console.WriteLine($"Демонстр. метода: "+String.Join(", ", GetArray(sz, minVal, maxVal)));

// Подсчитывает количество четных чисел в массиве
int Count()
{
    int[] Array = new int[sz];
    Array = GetArray(sz, minVal, maxVal);
    Console.WriteLine($"Тут подсчитываются четные числа: "+String.Join(", ", Array));
    int Reg = 0;
    for(int ix = 0; ix < 6; ix++)
    {
        if(Array[ix] % 2 == 0)
        {
            Reg = Reg + 1;
        }
    }
    return Reg;
}

Console.WriteLine($"Количество четных числел в массиве: {Count()}");