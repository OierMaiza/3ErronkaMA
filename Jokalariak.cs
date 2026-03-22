using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskalMus
{
public class Jokalariak
    {
        public string izena { get; set; }
        public string abizena { get; set; }
        public string emaila { get; set; }
        public string telefonoa { get; set; }
        public string herria { get; set; }
        public string pasahitza { get; set; }

        public Jokalariak(string izena, string abizena, string emaila, string telefonoa, string herria, string pasahitza)
        {
            this.izena = izena;
            this.abizena = abizena;
            this.emaila = emaila;
            this.telefonoa = telefonoa;
            this.herria = herria;
            this.pasahitza = pasahitza;
        }
       

    }
}
