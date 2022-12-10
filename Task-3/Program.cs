// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;

    if (numM != 0 && numN == 0) return AckermanFunction(numM - 1, 1);

    if (numM > 0 && numN > 0) return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));

    return AckermanFunction(numM, numN);
}

bool CheckNumbers(int numM, int numN)
{
    if (numM <= 0 || numN <= 0) return false;
    return true;
}

// Решил модернизировать код проверки

while (true)
{
    Console.WriteLine("Введите два числа");
    Console.WriteLine();
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if (CheckNumbers(m, n) == false)
    {
        Console.WriteLine();
        Console.WriteLine($"Введённые числа неположительные, M = {m}, N = {n}, повторите попытку");
        Console.WriteLine();
        Thread.Sleep(3000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Функция Аккермана для чисел A({m}, {n}) = {AckermanFunction(m, n)}");
        break;
    }
}