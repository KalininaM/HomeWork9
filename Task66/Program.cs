/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNumbers(int m, int n)

{
    if (m == n) return n;                       
    else if (m <= n) return m + SumNumbers(m + 1, n); 
    else return n + SumNumbers(m, n + 1);         
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

int numberM = ReadInt("значение M");
int numberN = ReadInt("значение N");
int sum = SumNumbers(numberM, numberN);

Console.WriteLine($"Сумма элементов в промежутке от {numberM} до {numberN} равна {sum}");