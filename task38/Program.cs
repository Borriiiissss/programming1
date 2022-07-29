/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int size = 0;
int max = 0;
int min = 0;
System.Console.WriteLine("введите размер массива ");
int.TryParse(Console.ReadLine(), out size);
int [] array = new int [size];

void FillArray (int[]array)
{
    for (int item=0; item<array.Length; item++)
    {
        array[item] = new Random().Next(0,100);
    }
}

void PrintArray (int[]array)
{
    System.Console.Write("[ ");
    for (int i=0; i<array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write("]");
}

int MaxMinusMin (int [] array)
{
    max = array[0];
    min = array[0];
    
    for (int i=1; i<array.Length; i++)
    {
        if (array[i]>max) max = array [i];
        if (array[i]<min) min = array [i];
    }
    int num = max - min;
    return num;
}

FillArray(array);
PrintArray(array);
System.Console.Write($" -> {MaxMinusMin(array)}");