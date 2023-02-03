// Программа, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого

Console.WriteLine("Enter two numbers");

string strnum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strnum1);
string strnum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strnum2);

int power = 2;
double Pow12 = Math.Pow(num1, power);
double Pow21 = Math.Pow(num2, power);
if (Pow12 == num2 || Pow21 == num1)

{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
    else
    {
        Console.WriteLine("Ни одно из чисeл не является квадратом другого");
    }


