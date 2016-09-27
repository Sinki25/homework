using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUr2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());

            if (a==1)
            {
                Console.Write("x^2");
            }
            else if (a==-1)
            {
                Console.Write("-x^2");
            }
            else if ((a>0) || (a<0))
            {
                Console.Write("{0}x^2",a);
            }
           
            if (b!=0)
            {
                if ((b==1) && (a!=0))
                {
                    Console.Write("+x");
                }

                else if ((b==1) && (a==0))
                {
                    Console.Write("x");
                }

                else if (b==-1)
                {
                    Console.Write("x");
                }
                else if ((b>0) && (a!=0))
                {
                    Console.Write("+{0}x", b);
                }
                else if ((b>0) && (a==0) || (b<0) || (a == 0))
                {
                    Console.Write("{0}x",b);
                }
            }
            if (c!=0)
            {
                if ((c>0) && (b!=0))
                {
                    Console.Write("+{0}", c);
                }
                else if ((c>0) && (b==0))
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write("{0}", c);
                }
            }
        }
    }
}
