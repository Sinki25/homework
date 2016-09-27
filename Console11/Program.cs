using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console11
{
    class Program
    {
        static void Main(string[] args)
        {
            int S,a,n,s;

            S = 0;
            
            for (int i = 1000; i <= 9999; i++)
            {
                n = i;s = 0;
                for(int j=1;j<=4;j++)
                {                   
                    a = n % 10;
                    n = n / 10;
                    s = s +(int) Math.Pow(a, 4);                  
                }
                if (i == s)
                    S = S + s;
            }
            Console.WriteLine(S);
        }
    }
}
