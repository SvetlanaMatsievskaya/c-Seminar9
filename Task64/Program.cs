int M = 0;
int.TryParse(Console.ReadLine(), out M);
int N = 0;
int.TryParse(Console.ReadLine(), out N);

string PrintNumbers(int M, int N)
{
if (M > N) 
{
    if (M==N)
    {
        return M.ToString();
    }
    return M + " " + PrintNumbers (M-1, N);    
}
else
{
    if (M == N)
    {
        return M.ToString();
    }
}
    return M + " " + PrintNumbers (M+1, N);   
}

Console.WriteLine(PrintNumbers(M,N));
