

int FibonacciCycle(int n)
{
    int prev = 0;
    int cur = 1;

    for (int i = 2; i <= n; i++)
    {
        int tmp = cur;
        cur += prev;
        prev = tmp;
    }

    return cur;
}

int FibonacciRecursive(int n)
{
    if (n == 0) return n;
    if (n == 1) return n;

    return FibonacciRecursive(n - 2) + FibonacciRecursive(n - 1);
}

bool IsPriveNumber(int n)
{
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}


for (int i = 0; i < 300; i++)
{
    Console.WriteLine(String.Format("{0}, {1}", i, IsPriveNumber(i)));
}




