// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int num = 0;
int m = 0;
int n = 0;
int IsItNumber()
{   
    System.Console.WriteLine(" введите число");
    if (int.TryParse(System.Console.ReadLine()!, out num)) System.Console.Write ("");
    else IsItNumber();
    return num;
}
m = IsItNumber();
n = IsItNumber();
double [,] array = new double [m,n];
int i = 0; int j = 0;
void FillArray (double [,] array, int m, int n)
{
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            array [i,j] = Math.Round (new Random().NextDouble() * 20 - 10 , 2);
            System.Console.Write($"{array [i,j]} ");
        }
        System.Console.WriteLine("");
    }
}
System.Console.WriteLine($"m = {m}, n = {n}");
FillArray(array, m, n);