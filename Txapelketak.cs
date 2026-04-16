using System;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Txapelketak : Form
    {
        // ==================== PROPIETATEAK ====================
        private int Id { get; set; }
        private string Izena { get; set; }
        private string Herria { get; set; }
        private string Tokia { get; set; }
        private string Egoera { get; set; }
        private int BikoteKant { get; set; }
        private DateTime Data { get; set; }

        public Txapelketak()
        {
            InitializeComponent();
        }

        public Txapelketak(int id, string izena, string herria, string tokia, string egoera, int bikoteKant, DateTime data)
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