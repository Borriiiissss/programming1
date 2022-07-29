// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [4];
int check = 0;
int count = 0;
void FillArray(int[]array)
{
for (int i=0; i<array.Length; i++)
    array[i] = new Random().Next (100,1000); 
}
FillArray(array);
void Count(int[]array)
{
    for (int element=0; element<array.Length; element++)
        {
            check = array[element] % 2;
            if (check == 0) count++;
        }
    System.Console.WriteLine(count); 
}
void PrintArray(int[]array)
{
    count=0;
for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i<array.Length-1) System.Console.Write(", ");
    }
}
System.Console.Write("[");
PrintArray(array);
System.Console.Write("] -> ");
Count(array);
