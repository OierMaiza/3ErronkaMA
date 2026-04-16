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
        private int id { get; set; }
        private int txapelketa_id { get; set; }
        private int faseZenbakia { get; set; }
        private int posizioa { get; set; }
        private int bikoteaA { get; set; }
        private int bikoteaB { get; set; }
        private int irabazlea { get; set; }
        private int galtzailea { get; set; }
        private string egoera { get; set; }

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


