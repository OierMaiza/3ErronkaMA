namespace EuskalMus
{
    partial class Bikoteak
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
            this.dgvBikoteak = new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblJokalaria1 = new System.Windows.Forms.Label();
            this.txtJokalaria1 = new System.Windows.Forms.TextBox();
            this.lblJokalaria2 = new System.Windows.Forms.Label();
            this.txtJokalaria2 = new System.Windows.Forms.TextBox();
            this.lblEzizena = new System.Windows.Forms.Label();
            this.txtEzizena = new System.Windows.Forms.TextBox();
            this.btnKargatu = new System.Windows.Forms.Button();
            this.btnTxertatu = new System.Windows.Forms.Button();
            this.btnEguneratu = new System.Windows.Forms.Button();
            this.btnEzabatu = new System.Windows.Forms.Button();

            // ── DataGridView ─────────────────────────────────────────────
            this.dgvBikoteak.BackgroundColor = System.Drawing.Color.White;
            this.dgvBikoteak.Location = new System.Drawing.Point(30, 80);
            this.dgvBikoteak.Name = "dgvBikoteak";
            this.dgvBikoteak.ReadOnly = true;
            this.dgvBikoteak.Size = new System.Drawing.Size(520, 320);


            // ── Titulua ──────────────────────────────────────────────────
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.Location = new System.Drawing.Point(30, 20);
            this.lblTitulua.Size = new System.Drawing.Size(400, 40);
            this.lblTitulua.Text = "BIKOTEAK KUDEATU";

            // ── ID ───────────────────────────────────────────────────────
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(580, 80);
            this.lblId.Size = new System.Drawing.Size(80, 25);
            this.lblId.Text = "ID:";

            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(670, 78);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 30);

            // ── Jokalaria1 ────────────────────────────────────────────────────
            this.lblJokalaria1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJokalaria1.Location = new System.Drawing.Point(580, 120);
            this.lblJokalaria1.Size = new System.Drawing.Size(80, 25);
            this.lblJokalaria1.Text = "Jokalaria1:";

            this.txtJokalaria1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJokalaria1.Location = new System.Drawing.Point(670, 118);
            this.txtJokalaria1.Size = new System.Drawing.Size(220, 30);

            // ── Jokalaria2 ───────────────────────────────────────────────────
            this.lblJokalaria2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJokalaria2.Location = new System.Drawing.Point(580, 160);
            this.lblJokalaria2.Size = new System.Drawing.Size(80, 25);
            this.lblJokalaria2.Text = "Jokalaria2:";

            this.txtJokalaria2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJokalaria2.Location = new System.Drawing.Point(670, 158);
            this.txtJokalaria2.Size = new System.Drawing.Size(220, 30);

            // ── Ezizena ────────────────────────────────────────────────────
            this.lblEzizena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEzizena.Location = new System.Drawing.Point(580, 200);
            this.lblEzizena.Size = new System.Drawing.Size(80, 25);
            this.lblEzizena.Text = "Ezizena:";

            this.txtEzizena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEzizena.Location = new System.Drawing.Point(670, 198);
            this.txtEzizena.Size = new System.Drawing.Size(220, 30);

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
            this.Text = "EuskalMus - Bikoteak Kudeatu";
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.Controls.Add(this.dgvBikoteak);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.lblId); this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblJokalaria1); this.Controls.Add(this.txtJokalaria1);
            this.Controls.Add(this.lblJokalaria2); this.Controls.Add(this.txtJokalaria2);
            this.Controls.Add(this.lblEzizena); this.Controls.Add(this.txtEzizena);
            this.Controls.Add(this.btnKargatu);
            this.Controls.Add(this.btnTxertatu);
            this.Controls.Add(this.btnEguneratu);
            this.Controls.Add(this.btnEzabatu);

        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvBikoteak;
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblJokalaria1;
        private System.Windows.Forms.TextBox txtJokalaria1;
        private System.Windows.Forms.Label lblJokalaria2;
        private System.Windows.Forms.TextBox txtJokalaria2;
        private System.Windows.Forms.Label lblEzizena;
        private System.Windows.Forms.TextBox txtEzizena;
        private System.Windows.Forms.Button btnKargatu;
        private System.Windows.Forms.Button btnTxertatu;
        private System.Windows.Forms.Button btnEguneratu;
        private System.Windows.Forms.Button btnEzabatu;
    }
}