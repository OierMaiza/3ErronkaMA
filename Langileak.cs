using System;
using System.Data;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Langileak : Form
    {
        // ==================== PROPIETATEAK ====================
        private string izena { get; set; }
        private string abizena { get; set; }
        private string emaila { get; set; }
        private string telefonoa { get; set; }
        private string rola { get; set; }

        // CRUD klasea
        private LangileakCrud crud = new LangileakCrud();

        // ==================== KONSTRUKTOREAK ====================
        public Langileak()
        {
            InitializeComponent();
            LotuBotoiak();
        }

        public Langileak(string izena, string abizena, string emaila,
                         string telefonoa, string rola)
        {
            this.izena = izena;
            this.abizena = abizena;
            this.emaila = emaila;
            this.telefonoa = telefonoa;
            this.rola = rola;

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

            dgvLangileak.SelectionChanged += dgvLangileak_SelectionChanged;
        }

        // ==================== SELECT ====================
        private void btnKargatu_Click(object sender, EventArgs e)
        {
            dgvLangileak.DataSource = crud.GetLangileak();
        }

        // ==================== INSERT ====================
        private void btnTxertatu_Click(object sender, EventArgs e)
        {
            if (!ValidatuEremuak()) return;

            crud.TxertatuLangilea(
                txtIzena.Text.Trim(),
                txtAbizena.Text.Trim(),
                txtEmaila.Text.Trim(),
                txtTelefonoa.Text.Trim(),
                txtRola.Text.Trim()
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e);
        }

        // ==================== UPDATE ====================
        private void btnEguneratu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Aukeratu langile bat taulatik lehenengo.", "Abisua",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatuEremuak()) return;

            crud.EguneratuLangilea(
                int.Parse(txtId.Text),
                txtIzena.Text.Trim(),
                txtAbizena.Text.Trim(),
                txtEmaila.Text.Trim(),
                txtTelefonoa.Text.Trim(),
                txtRola.Text.Trim()
            );

            GarbituFormularioa();
            btnKargatu_Click(sender, e);
        }

        // ==================== DELETE ====================
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Aukeratu langile bat taulatik lehenengo.", "Abisua",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult erantzuna = MessageBox.Show(
                "Ziur zaude langilea ezabatu nahi duzula?", "Berrestatu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (erantzuna == DialogResult.Yes)
            {
                crud.EzabatuLangilea(int.Parse(txtId.Text));
                GarbituFormularioa();
                btnKargatu_Click(sender, e);
            }
        }

        // ==================== TAULA → FORMULARIOA ====================
        private void dgvLangileak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLangileak.CurrentRow == null) return;

            DataGridViewRow row = dgvLangileak.CurrentRow;

            txtId.Text = row.Cells["id"].Value?.ToString() ?? "";
            txtIzena.Text = row.Cells["izena"].Value?.ToString() ?? "";
            txtAbizena.Text = row.Cells["abizena"].Value?.ToString() ?? "";
            txtEmaila.Text = row.Cells["emaila"].Value?.ToString() ?? "";
            txtTelefonoa.Text = row.Cells["telefonoa"].Value?.ToString() ?? "";
            txtRola.Text = row.Cells["rola"].Value?.ToString() ?? "";
        }

        // ==================== LAGUNTZAILEAK ====================
        private bool ValidatuEremuak()
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) ||
                string.IsNullOrWhiteSpace(txtAbizena.Text) ||
                string.IsNullOrWhiteSpace(txtEmaila.Text))
            {
                MessageBox.Show("Izena, abizena eta emaila derrigorrezkoak dira.",
                    "Abisua", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtRola.Text = "";
        }
    }
}