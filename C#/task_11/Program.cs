// Программа, которая выводит случайное трехзначеное число и удаляет вторую цифру этого числа

int rand = new Random().Next(100, 1000);
Console.WriteLine($"Initial random number: {rand}  ");
int number3 = rand % 10;
int number1 = rand / 100;
Console.WriteLine($"Number1 = {number1}");
Console.WriteLine($"Number3 = {number3}");
int number = number1 * 10 + number3;
Console.WriteLine($"Worked random number {number}");

