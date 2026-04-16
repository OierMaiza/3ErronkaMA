namespace EuskalMus
{
    partial class Jokalariak
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
            this.dgvJokalariak= new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIzena = new System.Windows.Forms.Label();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.lblAbizena = new System.Windows.Forms.Label();
            this.txtAbizena = new System.Windows.Forms.TextBox();
            this.lblEmaila = new System.Windows.Forms.Label();
            this.txtEmaila = new System.Windows.Forms.TextBox();
            this.lblPasahitza = new System.Windows.Forms.Label();
            this.txtPasahitza = new System.Windows.Forms.TextBox();
            this.lblTelefonoa = new System.Windows.Forms.Label();
            this.txtTelefonoa = new System.Windows.Forms.TextBox();
            this.lblHerria = new System.Windows.Forms.Label();
            this.txtHerria = new System.Windows.Forms.TextBox();
            this.btnKargatu = new System.Windows.Forms.Button();
            this.btnTxertatu = new System.Windows.Forms.Button();
            this.btnEguneratu = new System.Windows.Forms.Button();
            this.btnEzabatu = new System.Windows.Forms.Button();

            // ── DataGridView ─────────────────────────────────────────────
            this.dgvJokalariak.BackgroundColor = System.Drawing.Color.White;
            this.dgvJokalariak.Location = new System.Drawing.Point(30, 80);
            this.dgvJokalariak.Name = "dgvJokalariak";
            this.dgvJokalariak.ReadOnly = true;
            this.dgvJokalariak.Size = new System.Drawing.Size(520, 320);


            // ── Titulua ──────────────────────────────────────────────────
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.Location = new System.Drawing.Point(30, 20);
            this.lblTitulua.Size = new System.Drawing.Size(400, 40);
            this.lblTitulua.Text = "JOKALARIAK KUDEATU";

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

            // ── Abizena ────────────────────────────────────────────────────
            this.lblAbizena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAbizena.Location = new System.Drawing.Point(580, 160);
            this.lblAbizena.Size = new System.Drawing.Size(80, 25);
            this.lblAbizena.Text = "Abizena:";

            this.txtAbizena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAbizena.Location = new System.Drawing.Point(670, 158);
            this.txtAbizena.Size = new System.Drawing.Size(220, 30);

            // ── Emaila ────────────────────────────────────────────────────
            this.lblEmaila.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmaila.Location = new System.Drawing.Point(580, 200);
            this.lblEmaila.Size = new System.Drawing.Size(80, 25);
            this.lblEmaila.Text = "Emaila:";

            this.txtEmaila.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmaila.Location = new System.Drawing.Point(670, 198);
            this.txtEmaila.Size = new System.Drawing.Size(220, 30);

            // ── Pasahitza ────────────────────────────────────────────────
            this.lblPasahitza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPasahitza.Location = new System.Drawing.Point(580, 240);
            this.lblPasahitza.Size = new System.Drawing.Size(80, 25);
            this.lblPasahitza.Text = "Pasahitza:";

            this.txtPasahitza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPasahitza.Location = new System.Drawing.Point(670, 238);
            this.txtPasahitza.Size = new System.Drawing.Size(220, 30);

            // ── Telefonoa (beti 32, ezin aldatu) ───────────────────────
            this.lblTelefonoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefonoa.Location = new System.Drawing.Point(580, 280);
            this.lblTelefonoa.Size = new System.Drawing.Size(90, 25);
            this.lblTelefonoa.Text = "Telefonoa:";

            this.txtTelefonoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefonoa.Location = new System.Drawing.Point(670, 278);
            this.txtTelefonoa.Size = new System.Drawing.Size(100, 30);

            // ── Herria ───────────────────────────────────────────────────
            this.lblHerria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHerria.Location = new System.Drawing.Point(580, 320);
            this.lblHerria.Size = new System.Drawing.Size(80, 25);
            this.lblHerria.Text = "Herria:";

            this.txtHerria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHerria.Location = new System.Drawing.Point(670, 318);
            this.txtHerria.Size = new System.Drawing.Size(150, 30);

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
            this.Text = "EuskalMus - Jokalariak Kudeatu";
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.Controls.Add(this.dgvJokalariak);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.lblId); this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIzena); this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.lblAbizena); this.Controls.Add(this.txtAbizena);
            this.Controls.Add(this.lblEmaila); this.Controls.Add(this.txtEmaila);
            this.Controls.Add(this.lblPasahitza); this.Controls.Add(this.txtPasahitza);
            this.Controls.Add(this.lblTelefonoa); this.Controls.Add(this.txtTelefonoa);
            this.Controls.Add(this.lblHerria); this.Controls.Add(this.txtHerria);
            this.Controls.Add(this.btnKargatu);
            this.Controls.Add(this.btnTxertatu);
            this.Controls.Add(this.btnEguneratu);
            this.Controls.Add(this.btnEzabatu);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvJokalariak;
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.Label lblAbizena;
        private System.Windows.Forms.TextBox txtAbizena;
        private System.Windows.Forms.Label lblEmaila;
        private System.Windows.Forms.TextBox txtEmaila;
        private System.Windows.Forms.Label lblPasahitza;
        private System.Windows.Forms.TextBox txtPasahitza;
        private System.Windows.Forms.Label lblTelefonoa;
        private System.Windows.Forms.TextBox txtTelefonoa;
        private System.Windows.Forms.Label lblHerria;
        private System.Windows.Forms.TextBox txtHerria;
        private System.Windows.Forms.Button btnKargatu;
        private System.Windows.Forms.Button btnTxertatu;
        private System.Windows.Forms.Button btnEguneratu;
        private System.Windows.Forms.Button btnEzabatu;
    }
}