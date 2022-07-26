// Задача 21
//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("введите x1");
double x1 = double.Parse(System.Console.ReadLine());
System.Console.WriteLine("введите y1");
double y1 = double.Parse(System.Console.ReadLine());
System.Console.WriteLine("введите z1");
double z1 = double.Parse(System.Console.ReadLine());
System.Console.WriteLine("введите x2");
double x2 = double.Parse(System.Console.ReadLine());
System.Console.WriteLine("введите y2");
double y2 = double.Parse(System.Console.ReadLine());
System.Console.WriteLine("введите z2");
double z2 = double.Parse(System.Console.ReadLine());

double Calculate()
{
double a1 = (x2-x1)*(x2-x1);
double a2 = (y2-y1)*(y2-y1);
double a3 = (z2-z1)*(z2-z1);
double distance = Math.Sqrt(a1+a2+a3);
return distance;
}
System.Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {Calculate()}");