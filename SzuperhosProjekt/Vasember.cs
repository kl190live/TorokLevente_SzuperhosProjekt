using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private Random RND = new Random();
        public Vasember() : base(150, true) { }

        public void KutyutKeszit()
        {
            Szuperero += RND.Next(0, 11);
        }

        public override bool MegmentiAVilagot()
        {
            if (MekkoraAzEreje() > 1000)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Vasember: " + base.ToString();
        }
    }
}