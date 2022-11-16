//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int SumRec(int start, int end);
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
        {
            return (end + start) * (end - start + 1) / 2;
        }
    }
    if (n == m)
    {
        return n.ToString();
    }
    else return n + SumRec(n - 1);
}
Console.Clear();
Console.Write("Введите первое число ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов {SumRec(m,n)}");

