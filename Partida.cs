using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskalMus
{
    public class Partida
    {

        public int id { get; set; }
        public int faseZenbakia { get; set; }
        public int posizioa { get; set; }
        public Bikotea BikoteaA { get; set; }
        public Bikotea BikoteaB { get; set; }
        public Bikotea Irabazlea { get; set; }
        public string Egoera { get; set; }

        public Partida(int id, int faseZenbakia, int posizioa, Bikotea bikoteaA, Bikotea bikoteaB, Bikotea irabazlea, String egoera)
        {
            this.id = id;
            this.faseZenbakia = faseZenbakia;
            this.posizioa = posizioa;
            this.BikoteaA = bikoteaA;
            this.BikoteaB = bikoteaB;
            this.Irabazlea = irabazlea;
            this.Egoera = egoera;
        }
    }
}
