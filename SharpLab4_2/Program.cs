using System;
using System.Runtime.InteropServices;

//calculating of x^(1/n)  *  sum from k = 1 to k = n of ((-1)^k * x^k / (2k + 1)!)

class SeriesSum
{
    [DllImport(@"TestLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int factorial(int n);

    [DllImport(@"TestLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern double pow(double num, int power);

    [DllImport(@"TestLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern double root(double num, int rootDegree);

    static void Main()
    {
        Console.Write("Enter positive integer (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter real number (x): ");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = 0;
        for(int k = 1; k <= n; k++)
        {
            if (k % 2 == 0)
                res += pow(x, k) / factorial(2 * k + 1);
            else
                res -= pow(x, k) / factorial(2 * k + 1);
        }
        res *= root(x, n);
        Console.WriteLine("The result is " + Convert.ToString(res));
        Console.ReadKey();
    }
}