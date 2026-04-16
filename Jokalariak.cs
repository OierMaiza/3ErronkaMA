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
    public partial class Jokalariak : Form
    {// ==================== PROPIETATEAK ====================//
        public string izena { get; set; }
        public string abizena { get; set; }
        public string emaila { get; set; }
        public string telefonoa { get; set; }
        public string herria { get; set; }
        public string pasahitza { get; set; }

        public Jokalariak()
        {
            InitializeComponent();

        }
        public Jokalariak(string izena, string abizena, string emaila, string telefonoa, string herria, string pasahitza)
        {
            this.izena = izena;

            this.abizena = abizena;

            this.emaila = emaila;

            this.telefonoa = telefonoa;

            this.herria = herria;

            this.pasahitza = pasahitza;


            InitializeComponent();

        }
    }
}