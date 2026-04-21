using System;
using System.Data;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Ranking : Form
    {
        // ==================== PROPIETATEAK ====================
        private int id { get; set; }
        private int jokalaria_id { get; set; }
        private string jokatutako_partidak { get; set; }
        private string irabazitako_partidak { get; set; }
        private string galdutako_partidak { get; set; }

        // CRUD klasea
        private RankingCrud crud = new RankingCrud();

        // ==================== KONSTRUKTOREAK ====================
        public Ranking()
        {
            InitializeComponent();
            LotuBotoiak();
        }

        public Ranking(int id, int jokalaria_id,
                       string jokatutako_partidak,
                       string irabazitako_partidak,
                       string galdutako_partidak)
        {
            InitializeComponent();

            this.id = id;
            this.jokalaria_id = jokalaria_id;
            this.jokatutako_partidak = jokatutako_partidak;
            this.irabazitako_partidak = irabazitako_partidak;
            this.galdutako_partidak = galdutako_partidak;

            LotuBotoiak();
        }

        // ==================== BOTOIAK LOTU ====================
        private void LotuBotoiak()
        {
            btnKargatu.Click += btnKargatu_Click;
        }

        // ==================== SELECT ====================
        private void btnKargatu_Click(object sender, EventArgs e)
        {
            DataTable dt = crud.GetRanking();
            dgvRanking.DataSource = dt;
        }
    }
}