/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] array = new int [8];
void FillArray(int[]array)
{
    for (int i=0; i<8; i++)
    {
        array [i] = new Random().Next(0,99);
        System.Console.Write(array [i]);
        if (i<7) System.Console.Write(", ");
    }
}
FillArray(array);
System.Console.Write(" -> [");
void PrintArray(int[]array)
{
    for (int i=0; i<8; i++)
    {    
        System.Console.Write(array[i]);
        if (i<7) System.Console.Write(", ");
    }
}
PrintArray(array);
System.Console.WriteLine("]");
