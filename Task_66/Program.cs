/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("input your number M: " );
int user_number_m = Convert.ToInt32(Console.ReadLine());
Console.Write("input your number N: " );
int user_number_n = Convert.ToInt32(Console.ReadLine());

int min = Math.Min(user_number_m, user_number_n);
int max = Math.Max(user_number_m, user_number_n);

int Sum_number (int m, int n)
{
    if (m <= n)
    {
        return m + Sum_number((m + 1), n);
    }
    else return 0;
}

Console.WriteLine($"Sum of numbers: {Sum_number(min, max)}");