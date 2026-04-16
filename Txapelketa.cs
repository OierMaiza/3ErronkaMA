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
    public partial class Txapelketa : Form
    {
        // ==================== PROPIETATEAK ====================
        public int id { get; set; }
        public string izena { get; set; }
        public string herria { get; set; }
        public string tokia { get; set; }
        public string egoera { get; set; }
        public int bikoteKant { get; set; }
        public DateTime data { get; set; }

        public Txapelketa()
        {
            InitializeComponent();
        }

        public Txapelketa(int id, string izena, string herria, string tokia, string egoera, int bikoteKant, DateTime data)
        {
            this.id = id;
            this.izena = izena;
            this.herria = herria;
            this.tokia = tokia;
            this.egoera = egoera;
            this.bikoteKant = bikoteKant;
            this.data = data;
            InitializeComponent();
        }
    }
}