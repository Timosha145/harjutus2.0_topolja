using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace harjutus2_topolja
{
    public abstract class Isik
    {
        public string nimi;
        public int synniaasta;
        public int vanus;
        public double sissetulek;
        public double maksuvaba;
        public double palk;
        public double tulumaks;
        public string wip;

        public enum sugu { Mees, Naine };
        public sugu Sugu;


        public Isik(string nimi, int synniaasta, sugu Sugu, double maksuvaba, double palk, double tulumaks)
        {
            this.nimi = nimi;
            this.synniaasta = synniaasta;
            this.Sugu = Sugu;
            this.maksuvaba = maksuvaba;
            this.palk = palk;
            this.tulumaks = tulumaks;
        }

        public abstract void print_Info();
        public int arvutaVanus()
        {
            vanus = DateTime.Now.Year - synniaasta;
            return vanus;
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }

        public abstract double arvutaSissetulek();

        public abstract string WIP();
         

    }
}
