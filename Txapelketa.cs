using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskalMus
{
public class Txapelketa
    {
        public int id { get; set; }
        public String izena { get; set; }
        public String herria { get; set; }
        public String tokia { get; set; }
        public String egoera { get; set; }
        public int bikote_kant { get; set; }

        public DateTime data { get; set; }
        public String argazkia { get; set; }
        public String deskribapena { get; set; }


        public Txapelketa(int id, string izena, string herria, string tokia, string egoera, int bikote_kant, DateTime data, string argazkia, string deskribapena)
        {
            this.id = id;
            this.izena = izena;
            this.herria = herria;
            this.tokia = tokia;
            this.egoera = egoera;
            this.bikote_kant = bikote_kant;
            this.data = data;
            this.argazkia = argazkia;
            this.deskribapena = deskribapena;
        }
    }
}
