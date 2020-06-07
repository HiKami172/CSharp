#include <stdio.h>

int factorial(int n)
{
	if (n == 0 || n == 1)
		return 1;
	return n * factorial(n - 1);
}

double pow(double x, int n)
{
	if (n == 0 || x == 1)
		return 1;
	if (x == 0)
		return 0;
	double res = x;
	while (n-- != 0)
		res *= x;
	return res;
}


double mabs(double x)
{
	return (x < 0) ? -x : x; 
}

double root(double num, int rootDegree)
{
	double eps = 0.00001;             //допустимая погрешность	
	double root = num / rootDegree;   //начальное приближение корня
	double rn = num;                  //значение корня последовательным делением
	int countiter = 0;                //число итераций
	while (mabs(root - rn) >= eps)
	{
		rn = num;
		for (int i = 1; i < rootDegree; i++)
		{
			rn = rn / root;
		}
		root = 0.5 * (rn + root);
		countiter++;
	}
	return root;
}