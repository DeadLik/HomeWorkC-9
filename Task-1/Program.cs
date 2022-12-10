// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbers(int num)
{
    if (num == 1)
    {
        Console.Write($"{num} ");
        return;
    }

    Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
}

bool CheckNumbers(int num)
{
    if (num <= 0) return false;
    return true;
}

// Решил модернизировать код проверки

while (true)
{
    Console.Write("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (CheckNumbers(number) == false)
    {
        Console.WriteLine();
        Console.WriteLine($"Введено ненатуральное число = ({number}), повторите попытку");
        Console.WriteLine();
        Thread.Sleep(3000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine();
        NaturalNumbers(number);
        break;
    }
}