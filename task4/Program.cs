// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = 0, num2 = 0, num3 = 0;

Console.WriteLine("введите число 1 ");
string userenter1 = Console.ReadLine();
num1 = int.Parse(userenter1);

Console.WriteLine("введите число 2 ");
string userenter2 = Console.ReadLine();
num2 = int.Parse(userenter2);

Console.WriteLine("введите число 3 ");
string userenter3 = Console.ReadLine();
num3 = int.Parse(userenter3);

if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine($"{num1}, {num2}, {num3} -> max = {num1} ");
}
else if  (num2 > num1 && num2 > num3)
{

    System.Console.WriteLine($"{num1}, {num2}, {num3} -> max = {num2} ");
}
else
    {System.Console.WriteLine($"{num1}, {num2}, {num3} -> max = {num3} ");}