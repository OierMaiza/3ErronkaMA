using System;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Txapelketa : Form
    {
        // ==================== PROPIETATEAK ====================
        public int Id { get; set; }
        public string Izena { get; set; }
        public string Herria { get; set; }
        public string Tokia { get; set; }
        public string Egoera { get; set; }
        public int BikoteKant { get; set; }
        public DateTime Data { get; set; }

        public Txapelketa()
        {
            InitializeComponent();
        }

        public Txapelketa(int id, string izena, string herria, string tokia, string egoera, int bikoteKant, DateTime data)
        {
            Id = id;
            Izena = izena;
            Herria = herria;
            Tokia = tokia;
            Egoera = egoera;
            BikoteKant = bikoteKant;
            Data = data;
            InitializeComponent();
        }
    }
}