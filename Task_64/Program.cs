/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void Show_numbers (int number)
{
    if (number >= 1)
    {
        Console.Write(number + ", ");
        Show_numbers(number - 1);
    }
}

Console.Write("input your number: " );
int user_number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {user_number} -> ");
Show_numbers(user_number);
Console.Write("\b\b ");