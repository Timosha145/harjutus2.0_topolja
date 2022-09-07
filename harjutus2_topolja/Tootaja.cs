using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjutus2_topolja
{
    class Tootaja : Isik
    {
        public string asutus;
        public string amet;
        public string kesOn;
        public Tootaja(string kesOn, string asutus, string amet, string nimi, int synniaasta, sugu Sugu, double maksuvaba, double palk, double tulumaks) : base(nimi, synniaasta, Sugu, maksuvaba, palk, tulumaks)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.kesOn = kesOn;
        }
        public override double arvutaSissetulek()
        {
            sissetulek = ((palk - maksuvaba) * (1-(tulumaks / 100))) + maksuvaba;
            return sissetulek;
        }

        public override string WIP()
        {
            if (amet == "õpetaja" || amet == "koristaja")
            {
                wip = "on wip";
                return wip;
            }
            else { return wip = "ei ole wip"; }
        }

        public override void print_Info()
        {
            Console.WriteLine($"Tema asutus koht on {asutus} ta {WIP()}, töötab {amet}na, tema netto töötasu on {arvutaSissetulek()}, tema nimi on {nimi} [{Sugu}] ja {arvutaVanus()} aastat vana");
        }
    }
}
