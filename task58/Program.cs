// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int k=2, l=2, m=2, n=2;
int [,] array1=new int [k,l];
int [,] array2=new int [m,n];
void FillPrintArray(int[,]array)
{
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            array[i,j]=new Random().Next(5);
            System.Console.Write($"{array[i,j]} ");
        }   
        System.Console.WriteLine();
    } 
    System.Console.WriteLine();  
}
void PrintArray(int[,]array)
{
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();   
    }   
}
FillPrintArray(array1); FillPrintArray(array2);
int [,] array3 = new int [k,l];
int i=0;int j=0;
for (i = 0; i < k-1; i++)
{
    for (j = 0; j < l-1; j++)
    {
        array3[i,j] = array1[i,j]*array2[i,j]+array1[i,j+1]*array2[i+1,j];
        array3[i+1,j] = array1[i+1,j]*array2[i,j]+array1[i+1,j+1]*array2[i+1,j];
        array3[i,j+1] = array1[i,j]*array2[i,j+1]+array1[i,j+1]*array2[i+1,j+1];
        array3[i+1,j+1] = array1[i+1,j]*array2[i,j+1]+array1[i+1,j+1]*array2[i+1,j+1];
    }
}
PrintArray(array3);