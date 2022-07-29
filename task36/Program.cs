/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int [] array = new int [4];
int sum = 0;
int count = 0;
int check = 0;
void FillArray(int [] array)
{
    for (int num =0; num < array.Length; num++)
    {
        array[num] = new Random().Next (-100, 100);
       
    }
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item);
        count++;
        if (count<array.Length) System.Console.Write(", ");
    }
}
int Sum (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        check = i % 2;
        if (check == 0) sum = sum + array[i]; 
    }
    return sum;
}
System.Console.Write("[ ");
FillArray(array); PrintArray(array);
System.Console.Write($" ] -> {Sum(array)}");     