using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBit4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,a;

            N = int.Parse(Console.ReadLine());

            while (N > 0)
            {
                a = N % 2;
                N = N / 2;
                Console.Write(a);
            }
            }
        }
    }

