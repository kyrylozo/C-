// Программа, принимающая на вход число (N) и показывающая на выходе все четные
// числа от 1 до N

Console.Write("Введите число N ");
string NumberN = Console.ReadLine();
//int N = Convert.ToInt32(NumberN); // это - наиболее универсальный вариант
int N = int.Parse(NumberN); // Этот вариант - только если аргумент - stirng
int i = 1;
Console.Write($"Все четные числа от 1 до {N}: ");
//Console.WriteLine(NumberN);
while(i < N + 1)
{
    if(i % 2 == 0) 
    {
        //Console.Write(i);
        //Console.Write("; ");
        Console.Write($"{i}; ");
        
    }
i++;
}



