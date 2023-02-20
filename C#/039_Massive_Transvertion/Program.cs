// 39. Переворачивает одномерный массив (последний элемент будет на первом месте, а первый - на последнем)

int CreateArrayVolume() // Создание случайного объема массива
{
    int volume = new Random().Next(3,25);
    return volume;
}

int[] CreateArray(int volume) // Создание массива объемом: "Volume"
{
    int[] Volume = new int[volume];
    return Volume;
}

int[] FillArray(int[] array) // Заполнение массива случайными цифрами от 1 до 9
{
    int[] Array = array;
    int count = Array.Length;
    Console.WriteLine($"Array volume: {count}");
    for (byte i = 0; i < count; i++)
    {
        Array[i] = new Random().Next(1,10);
    }
    return Array;
}


int[] InvertArray(int[] array) // Переворачивавет одномерный массив
{
    int temp = 0;
    for(byte i = 0; i <= (array.Length -1) / 2; i++)
    {
        temp = array[i];
        array[i] = array[((array.Length - 1) - i)];
        array[((array.Length - 1) - i)] = temp;
    }
    return array;
}
int[] CreatedArray = FillArray(CreateArray(CreateArrayVolume()));
Console.WriteLine(String.Join(" ,", CreatedArray));

Console.WriteLine(String.Join(" ,", InvertArray(CreatedArray)));