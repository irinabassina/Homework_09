// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalElem(int minNumber, int maxNumber)
{
    if (minNumber < 0) return SumNaturalElem(1, maxNumber);
    if (maxNumber < 0) return SumNaturalElem(1, minNumber);
    if (minNumber == maxNumber) return maxNumber;
    else return SumNaturalElem(minNumber + 1, maxNumber) + minNumber;
}
int minNumber = 1;
int maxNumber = 1;
Console.WriteLine("Enter number M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N:");
int n = Convert.ToInt32(Console.ReadLine());
if (m <= n)
{
    minNumber = m;
    maxNumber = n;
}
else
{
    minNumber = n;
    maxNumber = m;
}
int sum = SumNaturalElem(minNumber, maxNumber);
Console.Write($"The sum of natural elements between M and N is {sum}");