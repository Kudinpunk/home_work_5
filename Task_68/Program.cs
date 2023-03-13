/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Fun_akk (int m, int n)
{
	if(m == 0) 
        return n + 1;

	if(m > 0 & n == 0)
		{
			return Fun_akk(m - 1, 1);
		}
		return Fun_akk(m - 1, Fun_akk(m, n - 1));
}

Console.Write("input m: ");
int user_m = Convert.ToInt32(Console.ReadLine());
Console.Write("input n: ");
int user_n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {Fun_akk(user_m, user_n)}");
