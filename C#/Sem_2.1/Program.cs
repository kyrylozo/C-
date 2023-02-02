// Программа, выводящая случайное число из отрезка [10, 99] и показывающая наибольшую 
//цифру числа

int number = new Random().Next(10,100); // Второе число не включается в инервал 

int number1 = number / 10; // Получаем целое число - десяток
int number2 = number % 10; // Дает остаток от деления

Console.WriteLine($"Number = {number}");
if(number1 > number2)
{
    Console.WriteLine($"number 1 ({number1}) больше number 2 ({number2})");
}
else if (number2 > number1)
{
    Console.WriteLine($"number 2 ({number2}) больше number 1 ({number1})");
}
else 
{
    Console.WriteLine($"number 1 ({number1}) равно number 2 ({number2})");
}
