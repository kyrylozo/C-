﻿// 32. Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2] 


int [] Array = GetArray(4, -8, 8);
Console.WriteLine(String.Join(" ", Array));


int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

for(int i = 0; i < Array.Length; i++)
{
    Array[i] = Array[i] * (-1);
    Console.Write($" {Array[i]}");
}



