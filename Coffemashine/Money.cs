using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffemashine
{
    public class Money
    {
        private int rub { get; set; }
        public int Rub
        {
            get { return rub; }
            set
            { 
                rub= value;
            }
            
        }
        public void GetMoney( int money)
        {
            rub =rub -money;
        }
    }
}
