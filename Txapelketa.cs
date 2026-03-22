using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskalMus
{
public class Txapelketa
    {
        public List<Partida> PartidaGuztiak { get; set; } = new List<Partida>();
        public Txapelketa(List<Partida> partidaGuztiak)
        {
            PartidaGuztiak = partidaGuztiak;
        }
    }
}
