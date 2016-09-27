using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console10
{
    class Program
    {
        static void Main(string[] args)
        {
            int S,a,k,n;
            S = 0;
            n = 0;
            a = 0;
            while(S<1000)
            {
                a++;
                k = 0;
                for(int i=2;i<=Math.Sqrt(a);i++)
                {
                    if (a % i == 0)
                        k++;
                    if (k > 0)
                        break;  
                }
                if (k==0)
                {
                    S = S+a;
                    n++;
                }
            }
            if (S > 1000)
                S = S-a;
            Console.WriteLine("Длина = {0}", n);
            Console.WriteLine(" Сумма = {0}", S);
        }
    }
}
