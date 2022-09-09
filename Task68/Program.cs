// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(n, m);

int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AkkermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    return AkkermanFunction(n, m);
}

int result = AkkermanFunction(m, n);
Console.WriteLine($"A(m, n) = {result}");