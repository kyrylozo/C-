// Создает двумерный массив размером m x n, заполненный случайными вещественными числами
// m = 3, n = 4

// Создание таблицы и наполнение ее случайными числами

void MakeArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"_{new Random().Next(1, 10)}|");
        }
        System.Console.WriteLine();
    }
} 

int[,] matrix = new int[3, 4];
MakeArray(matrix);








