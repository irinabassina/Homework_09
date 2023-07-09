// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ShowNaturalNumber(int n, int m)
{
    if (n < 1)
    {
        Console.WriteLine("Number N is not natural!");
        return -1;
    }
    if (n == m)
        return n;
    else Console.Write($"{ShowNaturalNumber(n, m + 1)}, ");
    return m;
}

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowNaturalNumber(n, 1));

