using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTestProject
{
	public class Fibonacci
	{
		public static List<int> GenerateFibonacci(int n)
		{

			List<int> fibonacciSeries = new List<int>();

			if (n <= 0)
				return fibonacciSeries;

			fibonacciSeries.Add(0);
			if (n > 1)
			{
				fibonacciSeries.Add(1);
			}

			for (int i = 2; i < n; i++)
			{
				int nextNumber = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
				fibonacciSeries.Add(nextNumber);
			}

			return fibonacciSeries;
		}
	}
}
