// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());


int GetSum(int m, int n)
{
    if (n > m) return n + GetSum(m, n - 1);
    return m;
}

if (m >= n)
{
    Console.WriteLine("Число n должно быть больше чем m!");
}
else
{
    int result = GetSum(m, n);
    Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}");
}



