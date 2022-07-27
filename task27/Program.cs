/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int a = int.Parse(System.Console.ReadLine()!);
int sum = 0;
int nextnum = a;
int Sum(int a)
{
    while (nextnum > 0)
        {        
            int num = nextnum % 10;
            nextnum = nextnum / 10;
            sum = sum + num;
        }
    return sum;
}
System.Console.WriteLine($"{a} -> {Sum(a)}");