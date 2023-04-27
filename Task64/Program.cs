/*Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
void PrintNum(int m)
{
    if(m >= 1){
        Console.Write(m + " ");
        PrintNum(m - 1);
    }
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Введите {argument}: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}

int numberA = ReadInt("значение N");
PrintNum(numberA);