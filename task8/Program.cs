// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num1 = 0, count = 1, check;

Console.WriteLine("введите число ");
string userenter1 = Console.ReadLine();
num1 = int.Parse(userenter1);

System.Console.Write($"{num1} -> ");

while (count < num1)
{
    check = count % 2;
    if (check == 0)
        System.Console.Write($"{count}, ");
    count = count + 1;
}
