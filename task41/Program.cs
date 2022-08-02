// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int number = 0;
int count = 0;
int quantity = 0;
int j = 0;
int IsItNumber() // ввод и проверка числа
{
    bool check = int.TryParse(System.Console.ReadLine(), out number);
    if (check == false) 
    {
        System.Console.WriteLine("можно ввести только число");
        IsItNumber();
    }
    return number;
}
int UserEnter ()
{
    System.Console.Write("сколько чисел будете вводить? ");
    return IsItNumber();
}
quantity = UserEnter();
int [] array = new int [quantity+1];
int MoreThanZero (int quantity) // подсчет положительных чисел, запись в массив, вывод массива
{
    System.Console.WriteLine($"введите числа используя ENTER");
    while (j<quantity)
    {                           
        array [j] = IsItNumber();
        if (array [j]>0) count++;
        j++;                                    
    }
    for (int i=0; i<array.Length-1; i++) {System.Console.Write($"{array[i]}, ");}
    return count;
}
System.Console.WriteLine($"-> {MoreThanZero(quantity)}");



