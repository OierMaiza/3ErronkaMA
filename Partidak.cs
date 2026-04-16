using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Partidak : Form
    {
        public int id { get; set; }
        public int txapelketa_id { get; set; }
        public int faseZenbakia { get; set; }
        public int posizioa { get; set; }
        public int bikoteaA { get; set; }
        public int bikoteaB { get; set; }
        public int irabazlea { get; set; }
        public int galtzailea { get; set; }
        public string egoera { get; set; }

        public Partidak(int id, int txapelketa_id, int faseZenbakia, int posizioa, int bikoteaA, int bikoteaB, int irabazlea, int galtzailea, string egoera)
        {
            this.id = id;
            this.txapelketa_id = txapelketa_id;
            this.faseZenbakia = faseZenbakia;
            this.posizioa = posizioa;
            this.bikoteaA = bikoteaA;
            this.bikoteaB = bikoteaB;
            this.irabazlea = irabazlea;
            this.galtzailea = galtzailea;
            this.egoera = egoera;
            InitializeComponent();
        }
        public Partidak()
        {
            InitializeComponent();
        }
    }
}


