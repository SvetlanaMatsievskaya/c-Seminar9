int M = 0;
int.TryParse(Console.ReadLine(), out M);
int N = 0;
int.TryParse(Console.ReadLine(), out N);

int SumNumbers(int M, int N)
{
int sum = 0;
if (M > N) 
{
    if (M==N)
    {
        return M;
    }
    return M + SumNumbers (M-1, N);    
}
else
{
    if (M == N)
    {
        return M;
    }
}
    return M + SumNumbers (M+1, N);   
}

Console.WriteLine(SumNumbers(M,N));

