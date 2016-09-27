using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s1, s2,k;

            n = int.Parse(Console.ReadLine());
            k = 0;

            for (int i = 1; i <= n; i++)
            {
                s1 = 0;
                for (int i1 = 1; i1 <= i; i1++)
                {
                    if (i % i1 == 0)
                        s1 = s1 + i1;
                }

                for (int j = 1; j <= n; j++)
                {
                    s2 = 0;
                    for (int j1 = 1; j1 <= j; j1++)
                    {
                        if (j % j1 == 0)
                            s2 = s2 + j1;
                    }
                    if ((s1 == s2) && (s1 == i + j) && (i + j < n))
                    {
                        Console.Write(i);
                        Console.Write(" ");
                        Console.Write(j);
                        Console.WriteLine();
                        k = 1;
                    }
                    
                }
             }
            if (k==0)
                    Console.WriteLine("Нет дружественных чисел");
            
        }
    }
}

