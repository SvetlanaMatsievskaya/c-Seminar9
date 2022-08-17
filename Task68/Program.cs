int M = 0;
int.TryParse(Console.ReadLine(), out M);
int N = 0;
int.TryParse(Console.ReadLine(), out N);


int rAckermann(int m, int n)
{
    
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0 && m > 0) 
    {
        return Ackerman(m - 1, 1);
    } 
    else 
    {
        return Ackermann(m - 1, recursion(m, n - 1));
    }
}
Console.WriteLine(Ackermann (M,N));