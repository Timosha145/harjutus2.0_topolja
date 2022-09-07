using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjutus2_topolja
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public string eriala;
        public string kursus;
        public double toetussumma;

        public string elamiskoht;
        public double perepalk;
        public int lastearv;
        public double keskhinne;

        double soidetoetus=0;
        double pohitoetus=0;
        double eritoetus=0;

        public string kesOn;

        public Kutsekooliopilane(string kesOn, double toetussumma, string elamiskoht, double perepalk, int lastearv, double keskhinne, string oppeasutus, string eriala, string kursus, string nimi, int synniaasta, sugu Sugu, double maksuvaba, double palk, double tulumaks) : base(nimi, synniaasta, Sugu, maksuvaba, palk, tulumaks)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.elamiskoht = elamiskoht;
            this.perepalk = perepalk;
            this.lastearv = lastearv;
            this.keskhinne = keskhinne;
            this.toetussumma = toetussumma;
            this.kesOn = kesOn;

        }

        public string Toetus()
        {
            if (elamiskoht != "Tallinn")
            {
                soidetoetus = 50;
            }
            if (perepalk<=300 || lastearv>2)
            {
                eritoetus = 90;
            }
            if (keskhinne>=3.3)
            {
                pohitoetus = 60;
            }
            string toetus = $"sõidetoetus {soidetoetus}, eritoetus {eritoetus}, põhitoetus {pohitoetus}";
            return toetus;
        }
        public override double arvutaSissetulek()
        {
            sissetulek = toetussumma + soidetoetus + eritoetus + pohitoetus;
            return sissetulek;
        }

        public override string WIP()
        {
            if (kursus == "TARpv21")
            {
                wip = "on wip";
                return wip;
            }
            else { return wip = "ei ole wip"; }
        }

        public override void print_Info()
        {
            Console.WriteLine($"Tema oppeasutus koht on {oppeasutus} ta {WIP()}, õpib {eriala}ka, {Toetus()}, tema töötasu on {arvutaSissetulek()}, tema nimi on {nimi} [{Sugu}] ja {arvutaVanus()} aastat vana");
        }
    }
}
