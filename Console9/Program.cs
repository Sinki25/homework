using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console9
{
    class Program
    {
        static void Main(string[] args)
        {
            int k,N,a,b,f,n,max;

            max = 0;
            n = 0;
            N= int.Parse(Console.ReadLine());
            k= int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == k)
                {
                        n++;
                    }
                    else
                    {
                        n = 0;
                    }
                
                    if (max < n)
                        max = n;
                
            }
            Console.WriteLine("Максимальная цепочка {0}", max);

        }
    }
}
