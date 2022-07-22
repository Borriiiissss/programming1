// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1 = 0, num2 = 0;

Console.WriteLine("введите число 1 ");
string userenter1 = Console.ReadLine();
num1 = int.Parse(userenter1);

Console.WriteLine("введите число 2 ");
string userenter2 = Console.ReadLine();
num2 = int.Parse(userenter2);

if (num1 > num2)
    System.Console.WriteLine($"a = {num1}, b = {num2} -> max = {num1} ");
else 
    System.Console.WriteLine($"a = {num1}, b = {num2} -> max = {num2} ");
