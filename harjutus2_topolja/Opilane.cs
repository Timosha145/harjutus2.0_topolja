using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjutus2_topolja
{
    class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public string spetsialiseerumine;
        public string kesOn;
        public Opilane(string kesOn, string koolinimi, string klass, string spetsialiseerumine, string nimi, int synniaasta, sugu Sugu, double maksuvaba, double palk, double tulumaks) : base(nimi, synniaasta, Sugu, maksuvaba, palk, tulumaks)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
            this.kesOn = kesOn;
        }

        public override string WIP()
        {
            if (klass == "9B" || klass == "9A")
            {
                wip = "on wip";
                return wip;
            }
            else { return wip = "ei ole wip"; }
        }

        public override void print_Info()
        {
            Console.WriteLine($"Tema koolinimi on {koolinimi} ta {WIP()} on {klass} klassis {spetsialiseerumine} spetsialiseerumises, tema nimi on {nimi} [{Sugu}] ja {arvutaVanus()} aastat vana");
        }

        public override double arvutaSissetulek()
        {
            throw new NotImplementedException();
        }
    }
}
