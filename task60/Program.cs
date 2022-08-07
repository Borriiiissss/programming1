// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int m=2, n=2, p=2;
int [,,]array=new int [m,n,p];
void FillArray(int[,,]array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j= 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                array[i,j,k]=new Random().Next(10,100);
                System.Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}
FillArray(array);