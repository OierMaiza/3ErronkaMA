using System;
using System.Data;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Bikoteak : Form
    {
        // ==================== PROPIETATEAK ====================
        private int jokalaria1_id { get; set; }
        private int jokalaria2_id { get; set; }
        private string ezizena { get; set; }

        // CRUD klasea
        private BikoteakCrud crud = new BikoteakCrud();

        // ==================== KONSTRUKTOREAK ====================
        public Bikoteak()
        {
            InitializeComponent();
            LotuBotoiak();
        }

        public Bikoteak(int jokalaria1_id, int jokalaria2_id, string ezizena)
        {
            this.jokalaria1_id = jokalaria1_id;
            this.jokalaria2_id = jokalaria2_id;
            this.ezizena = ezizena;

            InitializeComponent();
            LotuBotoiak();
        }

        public Bikoteak(int id, int jokalaria1_id, int jokalaria2_id, string ezizena)
            : this(jokalaria1_id, jokalaria2_id, ezizena)
        {
            // IDa update‑an erabiltzeko
        }

        // ==================== BOTOIAK LOTU ====================
        private void LotuBotoiak()
        {
            btnKargatu.Click += btnKargatu_Click;
            btnTxertatu.Click += btnTxertatu_Click;
            btnEguneratu.Click += btnEguneratu_Click;
            btnEzabatu.Click += btnEzabatu_Click;

            dgvBikoteak.SelectionChanged += dgvBikoteak_SelectionChanged;
        }

        // ==================== SELECT ====================
        private void btnKargatu_Click(object sender, EventArgs e)
        {
            dgvBikoteak.DataSource = crud.GetBikoteak();
        }

        // ==================== INSERT ====================
        private void btnTxertatu_Click(object sender, EventArgs e)
        {
            crud.TxertatuBikotea(
                int.Parse(txtJokalaria1.Text),
                int.Parse(txtJokalaria2.Text),
                txtEzizena.Text.Trim()
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e);
        }

        // ==================== UPDATE ====================
        private void btnEguneratu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Aukeratu bikote bat lehenengo.");
                return;
            }

            crud.EguneratuBikotea(
                int.Parse(txtId.Text),
                int.Parse(txtJokalaria1.Text),
                int.Parse(txtJokalaria2.Text),
                txtEzizena.Text.Trim()
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e);
        }

        // ==================== DELETE ====================
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Aukeratu bikote bat lehenengo.");
                return;
            }

            if (MessageBox.Show("Ziur zaude bikotea ezabatu nahi duzula?",
                "Berrestatu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                crud.EzabatuBikotea(int.Parse(txtId.Text));
                GarbituFormularioa();
                btnKargatu_Click(sender, e);
            }
        }

        // ==================== GRID → FORM ====================
        private void dgvBikoteak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBikoteak.CurrentRow == null) return;

            var row = dgvBikoteak.CurrentRow;

            txtId.Text = row.Cells["id"].Value?.ToString();
            txtJokalaria1.Text = row.Cells["jokalaria1_id"].Value?.ToString();
            txtJokalaria2.Text = row.Cells["jokalaria2_id"].Value?.ToString();
            txtEzizena.Text = row.Cells["ezizena"].Value?.ToString();
        }

        // ==================== GARBITU ====================
        private void GarbituFormularioa()
        {
            txtId.Text = "";
            txtJokalaria1.Text = "";
            txtJokalaria2.Text = "";
            txtEzizena.Text = "";
        }
    }
}