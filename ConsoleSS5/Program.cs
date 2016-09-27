using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSS5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,M,k,m,a;
            String A;


            Console.WriteLine("Введите два числа");
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите системы счисления");
            k = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            A = "";
            while (N>0)
            {
                a = Convert.ToChar(N % k);
                A+=a;
                N = N / k;
            }

            char[] array = A.ToCharArray();
            Array.Reverse(array);
            A = new string(array);

            Console.WriteLine("Первое число {0}",A);
            A = "";
            while (M > 0)
            {
                a = Convert.ToChar(M % m);
                A += a;
                M = M / m;
            }

            char[] array1 = A.ToCharArray();
            Array.Reverse(array1);
            A = new string(array1);
            Console.WriteLine("Второе число {0}", A);

           

        }
    }
}
