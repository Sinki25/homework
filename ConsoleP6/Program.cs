using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,k,a,P;

            N = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            P = 1;

            while (N>0)
            {
                a = N % k;
                N = N / k;
                P = P * a;
            }

            Console.WriteLine("Произведение равно {0}", P);

        }
    }
}
