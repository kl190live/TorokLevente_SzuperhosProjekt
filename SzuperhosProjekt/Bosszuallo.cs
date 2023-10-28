using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }


        bool ISzuperhos.LegyoziE(ISzuperhos szuperhos)
        {
            throw new NotImplementedException();
        }

        public abstract bool MegmentiAvilagot();

        double ISzuperhos.MekkoraAzEreje()
        {
            return szuperero;
        }

        public override string ToString()
        {
            return $"Szupererő: {szuperero}; {(vanEGyengesege ? "van gyengesége" : "nincs gyengesége")}";
        }

    }
}
