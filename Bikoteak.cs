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
    public partial class Bikoteak : Form
    {
        private int id { get; set; }
        private int jokalaria1_id { get; set; }
        private int jokalaria2_id { get; set; }
        private string ezizena { get; set; }

        public Bikoteak(int id, int jokalaria1_id, int jokalaria2_id, string ezizena)
        {
            InitializeComponent();
            this.id = id;
            this.jokalaria1_id = jokalaria1_id;
            this.jokalaria2_id = jokalaria2_id;
            this.ezizena = ezizena;
        }
        public Bikoteak()
        {
            InitializeComponent();
        }
    }
}
