// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num1 = 0, check;

Console.WriteLine("введите число ");
string userenter1 = Console.ReadLine();
num1 = int.Parse(userenter1);

check = num1 % 2;
System.Console.WriteLine(check);

if (check == 0)
{
    System.Console.WriteLine($"{num1} -> да ");
}
else 
{
    System.Console.WriteLine($"{num1} -> нет ");
}