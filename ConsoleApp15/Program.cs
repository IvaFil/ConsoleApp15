using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
			void PrintInterval(int m, int n)
			{
				int start = m;
				int end = n;
				if (m > n)
				{
					start = n;
					end = m;
				}
				for (int i = start; i <= end; i++)
				{
					Console.Write($"{i} ");
				}
			}
			PrintInterval(7, 34);

			Console.WriteLine();

			

		}
    }
}
