// 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Метод заполнения рандомом и метод для печати

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] Array = new int[8];
for(byte index = 0; index < 8; index++)
{
    Array[index] = new Random().Next(3,13);
}
System.Console.Write(String.Join(", ", Array));


// Console.Write(String.Join(", ", Get_AB()));