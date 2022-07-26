// Задача 23
//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int n = int.Parse(Console.ReadLine());
System.Console.WriteLine($"{n} -> ");
for (int i=1; i<n && i*i*i<n; i++)
    System.Console.WriteLine(i*i*i);