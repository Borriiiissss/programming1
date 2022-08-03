// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int i=0, m=4, n=3;
int [,] array = new int [m,n];
void FillPrintArray(int[,]array)
{
    for (i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(10);
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
void PrintAverageOfEveryColumn()
{
    for (int i = 0; i<n; i++)
    {
        int j=0;
        double sum=0;
        while (j<m)
        {
            sum+=array[j,i];
            j++;
        }
        System.Console.Write($" {sum} / {m} = {sum/m} ");
    }
}
FillPrintArray(array);
System.Console.Write("среднее арифметическое каждого столбца: ");
PrintAverageOfEveryColumn();