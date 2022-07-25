// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Show ()
{
    int inp = int.Parse(Console.ReadLine());
    string output = inp.ToString();
    Console.WriteLine($"{inp} -> {output [1]}");
}

Show ();