using System;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Partidak : Form
    {
        private PartidakCrud crud = new PartidakCrud();

        public Partidak()
        {
            InitializeComponent();
            btnKargatu.Click += BtnKargatu_Click;
            btnEguneratu.Click += BtnEguneratu_Click;
            dgvPartidak.SelectionChanged += DgvPartidak_SelectionChanged;
        }

        private void BtnKargatu_Click(object sender, EventArgs e)
        {
            dgvPartidak.DataSource = crud.GetPartidak();
        }

        private void BtnEguneratu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;

            crud.EguneratuPartida(
                int.Parse(txtId.Text),
                int.Parse(txtIrabazlea_id.Text),
                int.Parse(txtGaltzailea_id.Text));

            BtnKargatu_Click(sender, e);
        }

        private void DgvPartidak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPartidak.CurrentRow == null) return;
            var r = dgvPartidak.CurrentRow;

            txtId.Text = r.Cells["id"].Value.ToString();
            txtTxapelketa_id.Text = r.Cells["txapelketa_id"].Value.ToString();
            txtFase_id.Text = r.Cells["faseZenbakia"].Value.ToString();
            txtPosizioa.Text = r.Cells["posizioa"].Value.ToString();
            txtBikoteA_id.Text = r.Cells["bikoteaA"].Value?.ToString();
            txtBikoteB_id.Text = r.Cells["bikoteaB"].Value?.ToString();
            txtEgoera.Text = r.Cells["egoera"].Value?.ToString();
            txtIrabazlea_id.Text = "";
            txtGaltzailea_id.Text = "";
        }
    }
}