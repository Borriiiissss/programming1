// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int InputNumber()
{
    Console.Write("введите цифру ");
    int num = int.Parse(Console.ReadLine());
    Console.Write(num);
    return num;
}
string CheckDay(int num)
{
    string checkresult;
    if (num > 5)
        checkresult = "да";
    else 
        checkresult = "нет";
    return checkresult;
}
Console.Write($" -> {CheckDay(InputNumber ())}");