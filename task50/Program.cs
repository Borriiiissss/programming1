// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int m=5, n=5;
int [,] array = new int [m,n];
void FillPrintArray(int [,] array)
{
    for (int i=0; i<m; i++) 
    {
        for (int j=0; j<n; j++)
        {array[i,j]=new Random().Next(10);
        System.Console.Write($"{array[i,j]} ");}
        System.Console.WriteLine();
    }   
}
int InputIndexAndCheckIsItNumber()
    {
        System.Console.WriteLine("введите индекс");
        if (int.TryParse(System.Console.ReadLine(), out int num)) Console.Write("");
        else InputIndexAndCheckIsItNumber();
        return num;
    }
int index1 = InputIndexAndCheckIsItNumber();
int index2 = InputIndexAndCheckIsItNumber();
FillPrintArray(array);
if (index1 < 0 || index1 >m-1 || index2 < 0 || index1 >n-1) 
System.Console.WriteLine($"{index1}{index2} - >такого числа в массиве нет");
else System.Console.WriteLine(array[index1,index2]);

