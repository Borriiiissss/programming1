// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 
mylabel:
    int a = int.Parse(Console.ReadLine());
    if (a < 10000 | a > 99999)
    {
        System.Console.WriteLine("введите пятизначное чило");
        goto mylabel;
    }
void CheckNumber()
    {
    string b = a.ToString();
    if (b[0] == b[4] && b[1] == b[3])
        System.Console.Write("да");
    else
        System.Console.Write("нет");
    }
System.Console.Write($"{a} -> "); CheckNumber();