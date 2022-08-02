// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
float IsItNumber()
{    
    if (float.TryParse(System.Console.ReadLine()!, out float number))
        System.Console.Write("");
    else 
    {
        System.Console.WriteLine("введите число");
        IsItNumber();
    }
    return number;
}
System.Console.WriteLine($"введите значение b1");
float b1 = IsItNumber();
System.Console.WriteLine($"введите значение b2");
float b2 = IsItNumber();
System.Console.WriteLine($"введите значение k1");
float k1 = IsItNumber();
System.Console.WriteLine($"введите значение k2");
float k2 = IsItNumber();
if (k1==k2) {System.Console.WriteLine("отрезки параллельны"); return;}
float x = (b2-b1)/(k1-k2);
System.Console.WriteLine(x);
float y = k1 * x + b1;
System.Console.WriteLine($"x = {x}, y = {y}");