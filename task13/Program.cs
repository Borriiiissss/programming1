// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int inp = int.Parse(Console.ReadLine());

void Show (int anynum)
{
    
    string output = inp.ToString();
    if (output.Length > 2) 
        Console.WriteLine($"{inp} -> {output [2]}");
    else 
        Console.WriteLine ("третья цифра отсутствует");       
}

Show (inp);
