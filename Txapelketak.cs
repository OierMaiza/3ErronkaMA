using System;
using System.Data;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Txapelketak : Form
    {
        // ==================== PROPIETATEAK ====================
        private string izena { get; set; }
        private string herria { get; set; }
        private string tokia { get; set; }
        private string egoera { get; set; }
        private int bikoteKant { get; set; }
        private DateTime data { get; set; }

        private string rola = "antolatzailea"; // default

        private TxapelketakCrud crud = new TxapelketakCrud();

        // ==================== KONSTRUKTOREAK ====================

        public Txapelketak()
        {
            InitializeComponent();
            LotuBotoiak();
            KargatuEgoerak();
            numBikoteKant.Value = 0;
        }

        public Txapelketak(int id, string izena, string herria, string tokia,
                           string egoera, int bikoteKant, DateTime data)
        {
            this.izena = izena;
            this.herria = herria;
            this.tokia = tokia;
            this.egoera = egoera;
            this.bikoteKant = bikoteKant;
            this.data = data;

            InitializeComponent();
            LotuBotoiak();
            KargatuEgoerak();
        }

        // ✅ ROLA jasotzen duen konstruktorea
        public Txapelketak(string rola) : this()
        {
            this.rola = rola;
            AplikatuRola();
        }

        // ==================== ROLAREN ARABERA UI ====================
        private void AplikatuRola()
        {
            if (rola == "epailea")
            {
                btnTxertatu.Visible = false;
                btnEzabatu.Visible = false;
                // Eguneratu bai (egoera aldatzeko)
            }
        }

        // ==================== BOTOIAK LOTU ====================
        private void LotuBotoiak()
        {
            btnKargatu.Click += btnKargatu_Click;
            btnTxertatu.Click += btnTxertatu_Click;
            btnEguneratu.Click += btnEguneratu_Click;
            btnEzabatu.Click += btnEzabatu_Click;
            dgvTxapelketak.SelectionChanged += dgvTxapelketak_SelectionChanged;
        }

        private void KargatuEgoerak()
        {
            cmbEgoera.Items.Add("Izen Ematen");
            cmbEgoera.Items.Add("Jokatzen");
            cmbEgoera.Items.Add("Amaituta");
            cmbEgoera.SelectedIndex = 0;
        }

        // ==================== SELECT ====================
        private void btnKargatu_Click(object sender, EventArgs e)
        {
            dgvTxapelketak.DataSource = crud.GetTxapelketak();
        }

        // ==================== INSERT ====================
        private void btnTxertatu_Click(object sender, EventArgs e)
        {
            crud.TxertatuTxapelketa(
                txtIzena.Text.Trim(),
                txtHerria.Text.Trim(),
                txtTokia.Text.Trim(),
                cmbEgoera.Text,
                32,
                dtpData.Value.Date
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e);
        }

        // ==================== UPDATE ====================
        private void btnEguneratu_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            crud.EguneratuTxapelketa(
                int.Parse(txtId.Text),
                txtIzena.Text.Trim(),
                txtHerria.Text.Trim(),
                txtTokia.Text.Trim(),
                cmbEgoera.Text,
                32,
                dtpData.Value.Date
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e);
        }

        // ==================== DELETE ====================
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show(
                "Ziur zaude txapelketa ezabatu nahi duzula?",
                "Berretsi",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                crud.EzabatuTxapelketa(int.Parse(txtId.Text));
                GarbituFormularioa();
                btnKargatu_Click(sender, e);
            }
        }

        // ==================== GRID → FORM ====================
        private void dgvTxapelketak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTxapelketak.CurrentRow == null) return;

            var row = dgvTxapelketak.CurrentRow;
            txtId.Text = row.Cells["id"].Value?.ToString() ?? "";
            txtIzena.Text = row.Cells["izena"].Value?.ToString() ?? "";
            txtHerria.Text = row.Cells["herria"].Value?.ToString() ?? "";
            txtTokia.Text = row.Cells["tokia"].Value?.ToString() ?? "";
            cmbEgoera.Text = row.Cells["egoera"].Value?.ToString() ?? "";

            var val = row.Cells["data"].Value;
            if (val == null || val == DBNull.Value || string.IsNullOrWhiteSpace(val.ToString()))
            {
                dtpData.Value = DateTime.Today; // valor por defecto manejable
            }
            else
            {
                dtpData.Value = Convert.ToDateTime(val);
            }
        }

        private void GarbituFormularioa()
        {
            txtId.Text = "";
            txtIzena.Text = "";
            txtHerria.Text = "";
            txtTokia.Text = "";
            cmbEgoera.SelectedIndex = 0;
            dtpData.Value = DateTime.Today;
        }
    }
}