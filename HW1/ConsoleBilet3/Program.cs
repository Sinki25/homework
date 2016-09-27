using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBilet3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,a,b,c,d,e,f;

            N = int.Parse(Console.ReadLine());

            f = N % 10;
            N = N / 10;
            e = N % 10;
            N = N / 10;
            d = N % 10;
            N = N / 10;
            c = N % 10;
            N = N / 10;
            b = N % 10;
            N = N / 10;
            a = N % 10;

            if (a+c+e==b+d+f)
            {
                Console.WriteLine("Билет счастливый");
            }
            else
            {
                Console.WriteLine("Билет не счастливый");
            }
        }

    }
}
