// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int m=4, n=4;
int[,]array=new int [m,n];
void FillArray(int[,]array)
{
    for (int i=0; i<m; i++)
    {
        for (int j = 0; j < n; j++)
        {  
            array[i,j] = new Random().Next(10);
        }
    }
}
void PrintArray(int [,]array)
{   
    for (int i=0; i<m; i++)
    {
        for (int j = 0; j < n; j++)
        {             
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
void ArrayRowSort(int[,]array)
{
    for (int i=0; i<m; i++)
    {
        int max=array[i,0];
        int count2=0, index=0;        
        while (count2 < n)
        {
            for (int j=count2; j<n; j++)
                {           
                    if(array[i,j]>max) {max=array[i,j]; index=j;}                                   
                }
            array[i,index]=array[i,count2];
            array[i,count2]=max;
            count2++;
            max=0;index=count2;
        }       
    }
}
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ArrayRowSort(array);
PrintArray(array);