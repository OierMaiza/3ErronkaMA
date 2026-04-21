namespace EuskalMus
{
    partial class Partidak
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.dgvPartidak = new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTxapelketa_id = new System.Windows.Forms.Label();
            this.txtTxapelketa_id = new System.Windows.Forms.TextBox();
            this.lblFase_id = new System.Windows.Forms.Label();
            this.txtFase_id = new System.Windows.Forms.TextBox();
            this.lblPosizioa = new System.Windows.Forms.Label();
            this.txtPosizioa = new System.Windows.Forms.TextBox();
            this.lblBikoteA_id = new System.Windows.Forms.Label();
            this.txtBikoteA_id = new System.Windows.Forms.TextBox();
            this.lblBikoteB_id = new System.Windows.Forms.Label();
            this.txtBikoteB_id = new System.Windows.Forms.TextBox();
            this.lblIrabazlea_id = new System.Windows.Forms.Label();
            this.txtIrabazlea_id = new System.Windows.Forms.TextBox();
            this.lblGaltzailea_id = new System.Windows.Forms.Label();
            this.txtGaltzailea_id = new System.Windows.Forms.TextBox();
            this.lblEgoera = new System.Windows.Forms.Label();
            this.txtEgoera = new System.Windows.Forms.TextBox();
            this.btnKargatu = new System.Windows.Forms.Button();
            this.btnEguneratu = new System.Windows.Forms.Button();

            // ── DataGridView ─────────────────────────────────────────────
            this.dgvPartidak.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartidak.Location = new System.Drawing.Point(30, 80);
            this.dgvPartidak.Name = "dgvPartidak";
            this.dgvPartidak.ReadOnly = true;
            this.dgvPartidak.Size = new System.Drawing.Size(520, 320);


            // ── Titulua ──────────────────────────────────────────────────
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.Location = new System.Drawing.Point(30, 20);
            this.lblTitulua.Size = new System.Drawing.Size(400, 40);
            this.lblTitulua.Text = "PARTIDAK KUDEATU";

            // ── ID ───────────────────────────────────────────────────────
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(580, 80);
            this.lblId.Size = new System.Drawing.Size(80, 25);
            this.lblId.Text = "ID:";

            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(670, 78);
            this.txtId.ReadOnly = true;
            this.txtId.Enabled = false;
            this.txtId.Size = new System.Drawing.Size(150, 30);

            // ── Txapelketa ID ────────────────────────────────────────────────
            this.lblTxapelketa_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTxapelketa_id.Location = new System.Drawing.Point(580, 120);
            this.lblTxapelketa_id.Size = new System.Drawing.Size(80, 25);
            this.lblTxapelketa_id.Text = "Txapelketa:";

            this.txtTxapelketa_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTxapelketa_id.Location = new System.Drawing.Point(670, 118);
            this.txtTxapelketa_id.ReadOnly = true;
            this.txtTxapelketa_id.Enabled = false;
            this.txtTxapelketa_id.Size = new System.Drawing.Size(220, 30);

            // ── Fase ID ────────────────────────────────────────────────────
            this.lblFase_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFase_id.Location = new System.Drawing.Point(580, 160);
            this.lblFase_id.Size = new System.Drawing.Size(80, 25);
            this.lblFase_id.Text = "Fase ID:";

            this.txtFase_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFase_id.Location = new System.Drawing.Point(670, 158);
            this.txtFase_id.ReadOnly = true;
            this.txtFase_id.Enabled = false;
            this.txtFase_id.Size = new System.Drawing.Size(220, 30);

            // ── Posizioa ────────────────────────────────────────────────────
            this.lblPosizioa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPosizioa.Location = new System.Drawing.Point(580, 200);
            this.lblPosizioa.Size = new System.Drawing.Size(80, 25);
            this.lblPosizioa.Text = "Posizioa:";

            this.txtPosizioa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosizioa.Location = new System.Drawing.Point(670, 198);
            this.txtPosizioa.ReadOnly = true;
            this.txtPosizioa.Enabled = false;
            this.txtPosizioa.Size = new System.Drawing.Size(220, 30);

            // ── Bikote A ────────────────────────────────────────────────
            this.lblBikoteA_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBikoteA_id.Location = new System.Drawing.Point(580, 240);
            this.lblBikoteA_id.Size = new System.Drawing.Size(80, 25);
            this.lblBikoteA_id.Text = "Bikote A";

            this.txtBikoteA_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBikoteA_id.Location = new System.Drawing.Point(670, 238);
            this.txtBikoteA_id.ReadOnly = true;
            this.txtBikoteA_id.Enabled = false;
            this.txtBikoteA_id.Size = new System.Drawing.Size(220, 30);

            // ── Bikote B ───────────────────────
            this.lblBikoteB_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBikoteB_id.Location = new System.Drawing.Point(580, 280);
            this.lblBikoteB_id.Size = new System.Drawing.Size(80, 25);
            this.lblBikoteB_id.Text = "Bikote B:";

            this.txtBikoteB_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBikoteB_id.Location = new System.Drawing.Point(670, 278);
            this.txtBikoteB_id.ReadOnly = true;
            this.txtBikoteB_id.Enabled = false;
            this.txtBikoteB_id.Size = new System.Drawing.Size(220, 30);

            // ── Irabazlea ───────────────────────────────────────────────────
            this.lblIrabazlea_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIrabazlea_id.Location = new System.Drawing.Point(580, 320);
            this.lblIrabazlea_id.Size = new System.Drawing.Size(80, 25);
            this.lblIrabazlea_id.Text = "Irabazlea:";

            this.txtIrabazlea_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIrabazlea_id.Location = new System.Drawing.Point(670, 318);
            this.txtIrabazlea_id.Size = new System.Drawing.Size(220, 30);

            // ── Galtzailea ───────────────────────────────────────────────────
            this.lblGaltzailea_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGaltzailea_id.Location = new System.Drawing.Point(580, 360);
            this.lblGaltzailea_id.Size = new System.Drawing.Size(80, 25);
            this.lblGaltzailea_id.Text = "Galtzailea:";

            this.txtGaltzailea_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGaltzailea_id.Location = new System.Drawing.Point(670, 358);
            this.txtGaltzailea_id.Size = new System.Drawing.Size(220, 30);

            // ── Egoera ───────────────────────────────────────────────────
            this.lblEgoera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEgoera.Location = new System.Drawing.Point(580, 400);
            this.lblEgoera.Size = new System.Drawing.Size(80, 25);
            this.lblEgoera.Text = "Egoera:";

            this.txtEgoera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEgoera.Location = new System.Drawing.Point(670, 398);
            this.txtEgoera.ReadOnly = true;
            this.txtEgoera.Enabled = false;
            this.txtEgoera.Size = new System.Drawing.Size(220, 30);

            // ── Botoiak ──────────────────────────────────────────────────
            System.Drawing.Color botoiKolorea = System.Drawing.Color.FromArgb(52, 152, 219);

            this.btnKargatu.Text = "KARGATU";
            this.btnKargatu.Location = new System.Drawing.Point(30, 420);
            this.btnKargatu.Size = new System.Drawing.Size(120, 45);
            this.btnKargatu.BackColor = botoiKolorea;
            this.btnKargatu.ForeColor = System.Drawing.Color.White;
            this.btnKargatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKargatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKargatu.FlatAppearance.BorderSize = 0;

            this.btnEguneratu.Text = "EGUNERATU";
            this.btnEguneratu.Location = new System.Drawing.Point(170, 420);
            this.btnEguneratu.Size = new System.Drawing.Size(120, 45);
            this.btnEguneratu.BackColor = botoiKolorea;
            this.btnEguneratu.ForeColor = System.Drawing.Color.White;
            this.btnEguneratu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEguneratu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEguneratu.FlatAppearance.BorderSize = 0;

            // ── Formularioa ──────────────────────────────────────────────
            this.Text = "EuskalMus - Partidak Kudeatu";
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.Controls.Add(this.dgvPartidak);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.lblId); this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTxapelketa_id); this.Controls.Add(this.txtTxapelketa_id);
            this.Controls.Add(this.lblFase_id); this.Controls.Add(this.txtFase_id);
            this.Controls.Add(this.lblPosizioa); this.Controls.Add(this.txtPosizioa);
            this.Controls.Add(this.lblBikoteA_id); this.Controls.Add(this.txtBikoteA_id);
            this.Controls.Add(this.lblBikoteB_id); this.Controls.Add(this.txtBikoteB_id);
            this.Controls.Add(this.lblIrabazlea_id); this.Controls.Add(this.txtIrabazlea_id);
            this.Controls.Add(this.lblGaltzailea_id); this.Controls.Add(this.txtGaltzailea_id);
            this.Controls.Add(this.lblEgoera); this.Controls.Add(this.txtEgoera);
            this.Controls.Add(this.btnKargatu);
            this.Controls.Add(this.btnEguneratu);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvPartidak;
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTxapelketa_id;
        private System.Windows.Forms.TextBox txtTxapelketa_id;
        private System.Windows.Forms.Label lblFase_id;
        private System.Windows.Forms.TextBox txtFase_id;
        private System.Windows.Forms.Label lblPosizioa;
        private System.Windows.Forms.TextBox txtPosizioa;
        private System.Windows.Forms.Label lblBikoteA_id;
        private System.Windows.Forms.TextBox txtBikoteA_id;
        private System.Windows.Forms.Label lblBikoteB_id;
        private System.Windows.Forms.TextBox txtBikoteB_id;
        private System.Windows.Forms.Label lblIrabazlea_id;
        private System.Windows.Forms.TextBox txtIrabazlea_id;
        private System.Windows.Forms.Label lblGaltzailea_id;
        private System.Windows.Forms.TextBox txtGaltzailea_id;
        private System.Windows.Forms.Label lblEgoera;
        private System.Windows.Forms.TextBox txtEgoera;
        private System.Windows.Forms.Button btnKargatu;
        private System.Windows.Forms.Button btnEguneratu;
    }
}