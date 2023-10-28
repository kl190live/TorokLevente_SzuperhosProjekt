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
            if (szuperhos.GetType() == typeof(Batman) && ((Batman)szuperhos).MekkoraAzEreje() < this.MekkoraAzEreje() * 2)
            {

                return true;
            }
            if (((Bosszuallo)szuperhos).VanEGyengesege && ((Bosszuallo)szuperhos).MekkoraAzEreje() < this.MekkoraAzEreje())
            {
                return true;
            }
            return false;
        }

        public abstract bool MegmentiAVilagot();

        public virtual double MekkoraAzEreje()
        {
            return szuperero;
        }

        public override string ToString()
        {
            return $"Szupererő: {szuperero}; {(vanEGyengesege ? "van gyengesége" : "nincs gyengesége")}";
        }

    }
}
