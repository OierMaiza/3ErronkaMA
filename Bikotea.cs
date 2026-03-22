using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskalMus
{
    public class Bikotea
    {
        public int id { get; set; }
        public string izena { get; set; }
        public Bikotea(int id, string izena)
        {
            this.id = id;
            this.izena = izena;
        }
    }
}
