// наименьший делитель
int  size = 0;

int IsItNumber()
{
if (int.TryParse(System.Console.ReadLine()!, out size))
System.Console.WriteLine("yes");
else
{System.Console.WriteLine("no");
IsItNumber();}
return size;
}
System.Console.WriteLine(IsItNumber());