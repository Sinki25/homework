using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCifra8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2;
            char y1, y2;

            x1 = int.Parse(Console.ReadLine());
            y1=char.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = char.Parse(Console.ReadLine());

            int k = Convert.ToInt32(y2 - y1);
           
            if ( (Math.Abs(x1-x2)==2) && (Math.Abs(k)==1))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
               
            }
        }
    }
}
