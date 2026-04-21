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
    public partial class Langileak : Form
    {
        private string izena { get; set; }
        private string abizena { get; set; }
        private string emaila { get; set; }
        private string telefonoa { get; set; }
        private string rola { get; set; }
        public Langileak()
        {
            InitializeComponent();
        }

        public Langileak(string izena, string abizena, string emaila, string telefonoa, string rola)
        {
            this.izena = izena;

            this.abizena = abizena;

            this.emaila = emaila;

            this.telefonoa = telefonoa;

            this.rola = rola;

            InitializeComponent();
        }
    }
}