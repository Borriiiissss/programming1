/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int a =  int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int mult = a;

int Mult(int mult)
{
    for (int i=1; i<b; i++)
    {
        mult = mult * a;
    }
    return mult;
}
System.Console.WriteLine($"{a}, {b} -> {Mult(mult)} ({a}^{b})");