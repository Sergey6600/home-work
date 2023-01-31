Console.Write("Введите число M:")
== Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ") ; 
Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);
// вызов функции "сумма чисел от M до N"
void SumFromMToN (int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}
// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
