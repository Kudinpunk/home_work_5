/*
Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

void Show_numbers (int m, int n)
{
    if (n >= m)
    {
        Console.Write(m + ", ");
        Show_numbers(m + 1, n);
    }
}

Console.Write("input M: " );
int user_m = Convert.ToInt32(Console.ReadLine());
Console.Write("input N: " );
int user_n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {user_m}; N = {user_n}. --> ");

if (user_n < user_m)
    Console.WriteLine("input N > M: " );
else
    Show_numbers(user_m, user_n);
Console.Write("\b\b ");
