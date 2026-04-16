namespace EuskalMus
{
    partial class Txapelketak
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
            this.dgvTxapelketak = new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIzena = new System.Windows.Forms.Label();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.lblHerria = new System.Windows.Forms.Label();
            this.txtHerria = new System.Windows.Forms.TextBox();
            this.lblTokia = new System.Windows.Forms.Label();
            this.txtTokia = new System.Windows.Forms.TextBox();
            this.lblEgoera = new System.Windows.Forms.Label();
            this.cmbEgoera = new System.Windows.Forms.ComboBox();
            this.lblBikoteKant = new System.Windows.Forms.Label();
            this.numBikoteKant = new System.Windows.Forms.NumericUpDown();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnKargatu = new System.Windows.Forms.Button();
            this.btnTxertatu = new System.Windows.Forms.Button();
            this.btnEguneratu = new System.Windows.Forms.Button();
            this.btnEzabatu = new System.Windows.Forms.Button();

            // ── DataGridView ─────────────────────────────────────────────
            this.dgvTxapelketak.BackgroundColor = System.Drawing.Color.White;
            this.dgvTxapelketak.Location = new System.Drawing.Point(30, 80);
            this.dgvTxapelketak.Name = "dgvTxapelketak";
            this.dgvTxapelketak.ReadOnly = true;
            this.dgvTxapelketak.Size = new System.Drawing.Size(520, 320);


            // ── Titulua ──────────────────────────────────────────────────
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.Location = new System.Drawing.Point(30, 20);
            this.lblTitulua.Size = new System.Drawing.Size(400, 40);
            this.lblTitulua.Text = "TXAPELKETAK KUDEATU";

            // ── ID ───────────────────────────────────────────────────────
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(580, 80);
            this.lblId.Size = new System.Drawing.Size(80, 25);
            this.lblId.Text = "ID:";

            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(670, 78);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 30);

            // ── Izena ────────────────────────────────────────────────────
            this.lblIzena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIzena.Location = new System.Drawing.Point(580, 120);
            this.lblIzena.Size = new System.Drawing.Size(80, 25);
            this.lblIzena.Text = "Izena:";

            this.txtIzena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIzena.Location = new System.Drawing.Point(670, 118);
            this.txtIzena.Size = new System.Drawing.Size(220, 30);

            // ── Herria ───────────────────────────────────────────────────
            this.lblHerria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHerria.Location = new System.Drawing.Point(580, 160);
            this.lblHerria.Size = new System.Drawing.Size(80, 25);
            this.lblHerria.Text = "Herria:";

            this.txtHerria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHerria.Location = new System.Drawing.Point(670, 158);
            this.txtHerria.Size = new System.Drawing.Size(220, 30);

            // ── Tokia ────────────────────────────────────────────────────
            this.lblTokia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTokia.Location = new System.Drawing.Point(580, 200);
            this.lblTokia.Size = new System.Drawing.Size(80, 25);
            this.lblTokia.Text = "Tokia:";

            this.txtTokia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTokia.Location = new System.Drawing.Point(670, 198);
            this.txtTokia.Size = new System.Drawing.Size(220, 30);

            // ── Egoera ───────────────────────────────────────────────────
            this.lblEgoera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEgoera.Location = new System.Drawing.Point(580, 240);
            this.lblEgoera.Size = new System.Drawing.Size(80, 25);
            this.lblEgoera.Text = "Egoera:";

            this.cmbEgoera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgoera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEgoera.Location = new System.Drawing.Point(670, 238);
            this.cmbEgoera.Size = new System.Drawing.Size(220, 30);

            // ── Bikote Kant (beti 32, ezin aldatu) ───────────────────────
            this.lblBikoteKant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBikoteKant.Location = new System.Drawing.Point(580, 280);
            this.lblBikoteKant.Size = new System.Drawing.Size(90, 25);
            this.lblBikoteKant.Text = "Bikote Kant:";

            this.numBikoteKant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numBikoteKant.Location = new System.Drawing.Point(670, 278);
            this.numBikoteKant.Size = new System.Drawing.Size(100, 30);
            this.numBikoteKant.Value = 32;
            this.numBikoteKant.Minimum = 32;
            this.numBikoteKant.Maximum = 32;   
            this.numBikoteKant.Enabled = false;

            // ── Data ─────────────────────────────────────────────────────
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblData.Location = new System.Drawing.Point(580, 320);
            this.lblData.Size = new System.Drawing.Size(80, 25);
            this.lblData.Text = "Data:";

            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(670, 318);
            this.dtpData.Size = new System.Drawing.Size(150, 30);

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

            this.btnTxertatu.Text = "TXERTATU";
            this.btnTxertatu.Location = new System.Drawing.Point(170, 420);
            this.btnTxertatu.Size = new System.Drawing.Size(120, 45);
            this.btnTxertatu.BackColor = botoiKolorea;
            this.btnTxertatu.ForeColor = System.Drawing.Color.White;
            this.btnTxertatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTxertatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxertatu.FlatAppearance.BorderSize = 0;

            this.btnEguneratu.Text = "EGUNERATU";
            this.btnEguneratu.Location = new System.Drawing.Point(310, 420);
            this.btnEguneratu.Size = new System.Drawing.Size(120, 45);
            this.btnEguneratu.BackColor = botoiKolorea;
            this.btnEguneratu.ForeColor = System.Drawing.Color.White;
            this.btnEguneratu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEguneratu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEguneratu.FlatAppearance.BorderSize = 0;

            this.btnEzabatu.Text = "EZABATU";
            this.btnEzabatu.Location = new System.Drawing.Point(450, 420);
            this.btnEzabatu.Size = new System.Drawing.Size(120, 45);
            this.btnEzabatu.BackColor = botoiKolorea;
            this.btnEzabatu.ForeColor = System.Drawing.Color.White;
            this.btnEzabatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEzabatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzabatu.FlatAppearance.BorderSize = 0;

            // ── Formularioa ──────────────────────────────────────────────
            this.Text = "EuskalMus - Txapelketak Kudeatu";
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.Controls.Add(this.dgvTxapelketak);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.lblId); this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIzena); this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.lblHerria); this.Controls.Add(this.txtHerria);
            this.Controls.Add(this.lblTokia); this.Controls.Add(this.txtTokia);
            this.Controls.Add(this.lblEgoera); this.Controls.Add(this.cmbEgoera);
            this.Controls.Add(this.lblBikoteKant); this.Controls.Add(this.numBikoteKant);
            this.Controls.Add(this.lblData); this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnKargatu);
            this.Controls.Add(this.btnTxertatu);
            this.Controls.Add(this.btnEguneratu);
            this.Controls.Add(this.btnEzabatu);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTxapelketak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBikoteKant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvTxapelketak;
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.Label lblHerria;
        private System.Windows.Forms.TextBox txtHerria;
        private System.Windows.Forms.Label lblTokia;
        private System.Windows.Forms.TextBox txtTokia;
        private System.Windows.Forms.Label lblEgoera;
        private System.Windows.Forms.ComboBox cmbEgoera;
        private System.Windows.Forms.Label lblBikoteKant;
        private System.Windows.Forms.NumericUpDown numBikoteKant;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnKargatu;
        private System.Windows.Forms.Button btnTxertatu;
        private System.Windows.Forms.Button btnEguneratu;
        private System.Windows.Forms.Button btnEzabatu;
    }
}