// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int m=5, n=5;
int x=0, y=0;
int generalCount=1; int count = 1;
int [,]array=new int [m,n];
void PrintArray(int[,]array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i,j]<10) System.Console.Write($"{array[i,j] / 10}{array[i,j] % 10} ");
            else System.Console.Write($"{array[i,j]} ");
        }
    System.Console.WriteLine();
    }    
}
while (generalCount<m*n+1)
{   
    System.Console.WriteLine();
    bool exit = false; // вправо
    do
    {        
        if (array[x,y]==0) {array[x,y]=generalCount;generalCount++;y++;} else {exit=true;x++;}
    }
    while (y<n-count && exit == false);    
    
    exit = false; // вниз
    do
    {
        if (array[x,y]==0) {array[x,y]=generalCount;generalCount++;x++;} else {exit=true;y--;}
    }
    while (x<m-count && exit == false);

    exit = false; // влево
    do
    {
        if (array[x,y]==0) {array[x,y]=generalCount;generalCount++;y--;} else {exit=true;y++;}
    }
    while (y>count-1 && exit == false);

    exit = false; // вверх
    do
    {
        if (array[x,y]==0) {array[x,y]=generalCount;generalCount++;x--;} else {exit=true;y++;}
    }
    while (x>count-1 && exit == false);   
    x++; y++; 
    count++; 
}
PrintArray(array);