// 34: Задает массив со случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// У вас разные массивы получаются .
//  Когда вы вызываете метод GetMassiv() 
// у вас формируется новый массив . Когда вы вывели его на экран командой 
// System.Console.WriteLine(String.Join(", ", GetMassiv())); - это 1 массив 
// Array = GetMassiv(); - это уже другой массив. Вам его нужно распечатать ,
//  и потом поместить эту переменную в метод Count() и там посчитать
// ===================================================
// Метод создания массива

int[] GetMassiv()
{
    int[] Massiv = new int[6];
    for(int ind = 0; ind < 6; ind++)
    {
        Massiv[ind] = new Random().Next(100, 1000);
    }
    return Massiv;
}

// Подсчитывает количество четных чисел в массиве
int Count()
{
    int[] Array = new int[6];
    Array = GetMassiv();
    Console.WriteLine(String.Join(", ", Array));
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
