using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,a,k,n;

            Console.WriteLine("Введите кол-во чисел");

            N = int.Parse(Console.ReadLine());
            n = 0;

            for (int i = 1; i <= N; i++)
            {
                a = int.Parse(Console.ReadLine());
                k = 0;
                for (int j = 2; j <= Math.Sqrt(a) + 1; j++)
                {
                    if (a % j == 0)
                        k++;
                    if (k > 0)
                        break;
                }
                if (k == 0)
                    n++;
            }

            Console.WriteLine("Кол-во простых чисел {0}", n);
                }
            }

        }
