// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// (НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNambers(int m, int n)
{
    if (m == n || m > n)
        return 0;
    else
    {
        return SummNambers(m + 1, n) + m;
    }
}
Console.Clear();
Console.Write("Введите значение М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummNambers(m, n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int functionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return functionAkkerman(m - 1, 1);
    }
    else
    {
        return (functionAkkerman(m - 1, functionAkkerman(m, n - 1)));
    }
}

Console.Clear();
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(functionAkkerman(m, n));
