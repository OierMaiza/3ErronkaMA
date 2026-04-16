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
    public partial class Ranking : Form
    {
        private int id { get; set; }

        private int jokalaria_id { get; set; }

        private string jokatutako_partidak { get; set; }

        private string irabazitako_partidak { get; set; }

        private string galdutako_partidak { get; set; }
        public Ranking(int id, int jokalaria_id, string jokatutako_partidak, string irabazitako_partidak, string galdutako_partidak)
        {
            InitializeComponent();
            this.id = id;
            this.jokalaria_id = jokalaria_id;
            this.jokatutako_partidak = jokatutako_partidak;
            this.irabazitako_partidak = irabazitako_partidak;
            this.galdutako_partidak = galdutako_partidak;
        }
        public Ranking()
        {
            InitializeComponent();
        }
    }
}
