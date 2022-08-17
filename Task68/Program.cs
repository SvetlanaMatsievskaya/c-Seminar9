int m = 0;
int.TryParse(Console.ReadLine(), out m);
int n = 0;
int.TryParse(Console.ReadLine(), out n);


int Ackermann(int m, int n)
{
    
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0 && m > 0) 
    {
        return Ackermann(m - 1, 1);
    } 
    else 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.WriteLine(Ackermann (m,n));

