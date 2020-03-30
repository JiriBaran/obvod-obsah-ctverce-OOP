using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsah_a_obvod_ctverce
{
    class Ctverec
    {
        private double strana;
        public Ctverec(double strana)
        {
            this.strana = strana;
        }

        public double Obvod()
        {
            return strana * 4;
        }

        public double Obsah()
        {
            return strana * strana;
        }
    }
}
