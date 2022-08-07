// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int m=6, n=4;
int [,] array=new int [m,n];
void FillPrintArray(int [,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=new Random().Next(10);
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
int numberOfMinRow=0;
int FindMin(int [,] array)
{
    int SumOfNumbersOfFirstRow=0;
    for (int l = 0; l < n; l++)
    {
        SumOfNumbersOfFirstRow += array[0,l];
    }
    int min=SumOfNumbersOfFirstRow;
    for (int i = 0; i < m; i++)
    {
        int sumOfNumbersInRow=0;
        for (int j = 0; j < n; j++)
        {
            sumOfNumbersInRow = sumOfNumbersInRow + array[i,j];            
        }
        System.Console.Write($" Сумма строки {i+1} - {sumOfNumbersInRow} \n");
        if (sumOfNumbersInRow<min) {min=sumOfNumbersInRow; numberOfMinRow=i;};
    }
    return numberOfMinRow;
}
FillPrintArray(array);
System.Console.WriteLine($"строка с наименьшей суммой элементов: {FindMin(array)+1}");