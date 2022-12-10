// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа");
Console.WriteLine();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumNaturalElements(m, n, 0);

void SumNaturalElements (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine();
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
        return;
    }
    sum += numM++;
    SumNaturalElements(numM, numN, sum);
}