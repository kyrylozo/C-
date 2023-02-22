// 41. Подсчитывает сколько чисел больше 0 при введении с клавиатуры М чисел

sbyte[] Array() // Создает массив из 5 ячеек
{
    sbyte[] Ar = new sbyte[9];
    return Ar;
}


sbyte[] FillArray(sbyte[] array) // Заполняет массив введенными числами
{
    sbyte[] Ar = Array();
    for(byte ix = 0; ix < Ar.Length; ix++)
    {
        Console.Write("Enter the number: ");
        Ar[ix] = sbyte.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Массив данных: "+String.Join(", ", Ar));
    return Ar;
}


sbyte NumPositive(sbyte[] array) // Подсчитывает количество положительных чисел
{
    sbyte result = 0;
    for(sbyte ix = 0; ix < array.Length; ix ++)
    {
        if(array[ix] > 0) 
        {
            result += 1;
        }
       
    }
    return result;
}
Console.WriteLine($"Количество положительных чисел: {NumPositive(FillArray(Array()))}");

