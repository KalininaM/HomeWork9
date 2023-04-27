// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int CalculAckerman(int m, int n)
{
    if (m == 0) return n = n + 1;
    else if ((n == 0)) return CalculAckerman(m - 1, 1);
    else return CalculAckerman(m - 1, CalculAckerman(m, n - 1));
}

int numberM = ReadInt("число M");
int numberN = ReadInt("число N");

Console.WriteLine($"A({numberM},{numberN}) = {CalculAckerman(numberM, numberN)}");