using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,k;

            a=int.Parse(Console.ReadLine());

            while (a!=0)
            {
                k=0;
                if (a<0)
                {
                    Console.WriteLine(Math.Abs(a));
                }
                if (a>0)
                {
                    while(k!=1)
                    {
                        for(int i=0; i<=a; i++)
                        {
                            if (a<=(int)Math.Pow(2,i))
                            {
                                a = (int)Math.Pow(2, i);
                                k = 1;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(a);
                }
                a = int.Parse(Console.ReadLine());

            }

        }
    }
}
