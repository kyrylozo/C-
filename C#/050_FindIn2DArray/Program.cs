/* 
50. Принмиает на вход позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
?????
*/
Console.Clear();
int[,] FillArray(int[,] matrix) // Создание двумерной матрицы со случайными числами
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10); // [1, 10)
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
    return matrix;
}
System.Console.WriteLine();


Console.Write("Введите номер строки: ");
sbyte m = sbyte.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
sbyte n = sbyte.Parse(Console.ReadLine());
System.Console.WriteLine();

void FindArray(int[,] matrix, sbyte m, sbyte n) // Нахождение в созданной матрице числа с заданным индексом
{
    if(m > 0
        && m <= matrix.GetLength(0)
        && n > 0
        && n <= matrix.GetLength(1))
    {
            for(int i = 0; i <= matrix.GetLength(0); i++)
            {
                if (i == m - 1)
                {
                    for(int j = 0; j <= matrix.GetLength(1); j++)
                    {
                        if (j == n - 1)
                        {
                        System.Console.WriteLine();
                        Console.WriteLine($"Значение ячейки = {matrix[i,j]}");
                        break;
                        }
                    }
                }
        
            }
            
    }
    else 
        {
            Console.Write("Такого элемента нет");
        }
}

int[,] matr = new int[10, 10]; // new int [строки (matr.GetLength(0)), столбцы (matr.GetLength(1))]

FindArray(FillArray(matr), m, n);


