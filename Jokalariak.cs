using System;
using System.Data;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Jokalariak : Form
    {
        // ==================== PROPIETATEAK ====================
        private string izena { get; set; }
        private string abizena { get; set; }
        private string emaila { get; set; }
        private string telefonoa { get; set; }
        private string herria { get; set; }
        private string pasahitza { get; set; }

        // CRUD klasea
        private JokalariakCrud crud = new JokalariakCrud();

        // ==================== KONSTRUKTOREAK ====================
        public Jokalariak()
        {
            InitializeComponent();
            LotuBotoiak();
        }

        public Jokalariak(string izena, string abizena, string emaila,
                          string telefonoa, string herria, string pasahitza)
        {
            this.izena = izena;
            this.abizena = abizena;
            this.emaila = emaila;
            this.telefonoa = telefonoa;
            this.herria = herria;
            this.pasahitza = pasahitza;

            InitializeComponent();
            LotuBotoiak();
        }

        // ==================== BOTOIAK LOTU ====================
        private void LotuBotoiak()
        {
            btnKargatu.Click += btnKargatu_Click;
            btnTxertatu.Click += btnTxertatu_Click;
            btnEguneratu.Click += btnEguneratu_Click;
            btnEzabatu.Click += btnEzabatu_Click;

            // Errenkada bat hautatzean formularioa betetzen du
            dgvJokalariak.SelectionChanged += dgvJokalariak_SelectionChanged;
        }

        // ==================== SELECT: KARGATU ====================
        private void btnKargatu_Click(object sender, EventArgs e)
        {
            DataTable dt = crud.GetJokalariak();
            dgvJokalariak.DataSource = dt;
        }

        // ==================== INSERT: TXERTATU ====================
        private void btnTxertatu_Click(object sender, EventArgs e)
        {
            if (!ValidatuEremuak()) return;

            crud.TxertatuJokalaria(
                txtIzena.Text.Trim(),
                txtAbizena.Text.Trim(),
                txtEmaila.Text.Trim(),
                txtTelefonoa.Text.Trim(),
                txtHerria.Text.Trim(),
                txtPasahitza.Text.Trim()
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e); // Taula freskatu
        }

        // ==================== UPDATE: EGUNERATU ====================
        private void btnEguneratu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Aukeratu jokalari bat taulatik lehenengo.", "Abisua",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatuEremuak()) return;

            crud.EguneratuJokalaria(
                int.Parse(txtId.Text),
                txtIzena.Text.Trim(),
                txtAbizena.Text.Trim(),
                txtEmaila.Text.Trim(),
                txtTelefonoa.Text.Trim(),
                txtHerria.Text.Trim(),
                txtPasahitza.Text.Trim()
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e); // Taula freskatu
        }

        // ==================== DELETE: EZABATU ====================
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Aukeratu jokalari bat taulatik lehenengo.", "Abisua",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult erantzuna = MessageBox.Show(
                "Ziur zaude jokalaria ezabatu nahi duzula?", "Berrestatu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (erantzuna == DialogResult.Yes)
            {
                crud.EzabatuJokalaria(int.Parse(txtId.Text));
                GarbituFormularioa();
                btnKargatu_Click(sender, e); // Taula freskatu
            }
        }

        // ==================== TAULA → FORMULARIOA ====================
        private void dgvJokalariak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJokalariak.CurrentRow == null) return;

            DataGridViewRow errenkada = dgvJokalariak.CurrentRow;

            txtId.Text = errenkada.Cells["id"].Value?.ToString() ?? "";
            txtIzena.Text = errenkada.Cells["izena"].Value?.ToString() ?? "";
            txtAbizena.Text = errenkada.Cells["abizena"].Value?.ToString() ?? "";
            txtEmaila.Text = errenkada.Cells["emaila"].Value?.ToString() ?? "";
            txtTelefonoa.Text = errenkada.Cells["telefonoa"].Value?.ToString() ?? "";
            txtHerria.Text = errenkada.Cells["herria"].Value?.ToString() ?? "";
            txtPasahitza.Text = "";
        }

        // ==================== LAGUNTZAILEAK ====================
        private bool ValidatuEremuak()
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) ||
                string.IsNullOrWhiteSpace(txtAbizena.Text) ||
                string.IsNullOrWhiteSpace(txtEmaila.Text))
            {
                MessageBox.Show("Izena, abizena eta emaila derrigorrezkoak dira.", "Abisua",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void GarbituFormularioa()
        {
            txtId.Text = "";
            txtIzena.Text = "";
            txtAbizena.Text = "";
            txtEmaila.Text = "";
            txtTelefonoa.Text = "";
            txtHerria.Text = "";
            txtPasahitza.Text = "";
        }
    }
}