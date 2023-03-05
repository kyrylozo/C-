// Задает двумерный массив из целых чисел и находит среднее арифм. элементов в каждом столбце

Console.Clear();
int[,] matr = new int[4, 3]; // Создание "пустой" матрицы

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


void MeanColumn (int[,] matrix) // Подсчет среднего по столбцам
{
    double mean1 = 0;
    double mean2 = 0;
    double mean3 = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
            {
                mean1 = mean1 + matrix[i,j];
            }
            else if(j == 1)
            {
                mean2 = mean2 + matrix[i,j];
            }
            else
            {
                mean3 = mean3 + matrix[i,j];
            }
        }
    }
    Console.WriteLine($"Среднее арифметическое 1-го столбца = {mean1 / matrix.GetLength(0)}");
    Console.WriteLine($"Среднее арифметическое 2-го столбца = {mean2 / matrix.GetLength(0)}");
    Console.WriteLine($"Среднее арифметическое 3-го столбца = {mean3 / matrix.GetLength(0)}");
}

MeanColumn(FillArray(matr));