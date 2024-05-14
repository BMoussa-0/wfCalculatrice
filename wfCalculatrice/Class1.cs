using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfCalculatrice
{
    public class Calcul
    {
        private int nb1;
        private int nb2;
        public Calcul(int nb1, int nb2) 
        {
            this.nb1 = nb1;
            this.nb2 = nb2;
        }

        public int Addition() 
        { 
            return this.nb1 + this.nb2;
        }

        public int Multiplication() 
        { 
            return this.nb1 * this.nb2;
        }
    
    }
}
