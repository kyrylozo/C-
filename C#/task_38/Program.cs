// 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

double[] Massiv() // Создание массива
{
    double[] Array = new double[6];
    for(byte ix = 0; ix < 6; ix++)
    {
        Array[ix] = new Random().Next(100, 10000);
        Array[ix] /= 100;
    }
    return Array;
}

double[] Ar = new double[6];
Ar = Massiv();
Console.WriteLine(String.Join("; ", Ar));
double max = 10;
double min = 1000;
for(byte ix = 0; ix < 6; ix++)
{
    if(Ar[ix] > max) max = Ar[ix];
        else if(Ar[ix] < min) min = Ar[ix];
}
double Differ = max - min;

Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Разница между максимумом и минимумом = {Differ}");

// =============================================================================
// Convert.ToDouble(rand.Next(-100, 100)/10.0)
// res[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);