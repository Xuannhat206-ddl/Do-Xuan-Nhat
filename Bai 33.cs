using System;

class Program
{
    
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    
    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
            return false;

        int sum = 1;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                sum += i;
        }

        return sum == n;
    }

    static void Main()
    {
        Console.Write("Nhập N: ");
        int N = int.Parse(Console.ReadLine());

        
        if (IsPrime(N))
            Console.WriteLine($"{N} là Số nguyên tố!");
        else
            Console.WriteLine($"{N} KHÔNG là Số nguyên tố.");

        
        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} là Số hoàn hảo!");
        else
            Console.WriteLine($"{N} KHÔNG là Số hoàn hảo.");

        
        Console.Write($"Dãy Fibonacci {N} số: ");

        int a = 0;
        int b = 1;

        for (int i = 0; i < N; i++)
        {
            Console.Write(a);

            if (i < N - 1)
                Console.Write(", ");

            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }
}