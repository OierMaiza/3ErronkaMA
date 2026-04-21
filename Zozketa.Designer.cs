namespace EuskalMus
{
    partial class Zozketa
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
            this.pnlGoikoa = new System.Windows.Forms.Panel();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblAzpitit = new System.Windows.Forms.Label();
            this.lblTxapLabel = new System.Windows.Forms.Label();
            this.cmbTxapelketak = new System.Windows.Forms.ComboBox();
            this.btnEginZozketa = new System.Windows.Forms.Button();
            this.lblEgoera = new System.Windows.Forms.Label();
            this.dgvPartidak = new System.Windows.Forms.DataGridView();
            this.btnItxi = new System.Windows.Forms.Button();
            this.pnlGoikoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidak)).BeginInit();
            this.SuspendLayout();

            // ── Koloreak ────────────────────────────────────────────
            System.Drawing.Color nagusia = System.Drawing.Color.FromArgb(44, 62, 80);
            System.Drawing.Color panela = System.Drawing.Color.FromArgb(52, 73, 94);
            System.Drawing.Color berdea = System.Drawing.Color.FromArgb(39, 174, 96);
            System.Drawing.Color gorria = System.Drawing.Color.FromArgb(192, 57, 43);
            System.Drawing.Color iluna = System.Drawing.Color.FromArgb(30, 45, 60);
            System.Drawing.Color testua = System.Drawing.Color.White;

            // ═══════════════════════════════════
            //  PANEL GOIKOA  (header)
            // ═══════════════════════════════════
            this.pnlGoikoa.BackColor = panela;
            this.pnlGoikoa.Location = new System.Drawing.Point(0, 0);
            this.pnlGoikoa.Size = new System.Drawing.Size(950, 90);
            this.pnlGoikoa.Controls.Add(this.lblTitulua);
            this.pnlGoikoa.Controls.Add(this.lblAzpitit);

            this.lblTitulua.Text = "🎲  Zozketa egitea";
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.ForeColor = testua;
            this.lblTitulua.Location = new System.Drawing.Point(25, 12);
            this.lblTitulua.AutoSize = true;

            this.lblAzpitit.Text = "Zozketa - Mus Txapelketak";
            this.lblAzpitit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAzpitit.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblAzpitit.Location = new System.Drawing.Point(28, 60);
            this.lblAzpitit.AutoSize = true;

            // ═══════════════════════════════════
            //  TXAPELKETA AUKERATZEKO AREA
            // ═══════════════════════════════════
            this.lblTxapLabel.Text = "Txapelketa hautatu:";
            this.lblTxapLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTxapLabel.ForeColor = testua;
            this.lblTxapLabel.Location = new System.Drawing.Point(30, 112);
            this.lblTxapLabel.AutoSize = true;

            this.cmbTxapelketak.Location = new System.Drawing.Point(30, 135);
            this.cmbTxapelketak.Size = new System.Drawing.Size(340, 32);
            this.cmbTxapelketak.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTxapelketak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTxapelketak.BackColor = panela;
            this.cmbTxapelketak.ForeColor = testua;
            this.cmbTxapelketak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ═══════════════════════════════════
            //  BOTOI NAGUSIA
            // ═══════════════════════════════════
            this.btnEginZozketa.Text = "🎲  ZOZKETA EGIN";
            this.btnEginZozketa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEginZozketa.Location = new System.Drawing.Point(400, 123);
            this.btnEginZozketa.Size = new System.Drawing.Size(230, 48);
            this.btnEginZozketa.BackColor = berdea;
            this.btnEginZozketa.ForeColor = testua;
            this.btnEginZozketa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEginZozketa.FlatAppearance.BorderSize = 0;
            this.btnEginZozketa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEginZozketa.Click += new System.EventHandler(this.btnEginZozketa_Click);

            // ═══════════════════════════════════
            //  EGOERA LABEL
            // ═══════════════════════════════════
            this.lblEgoera.Text = "";
            this.lblEgoera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblEgoera.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblEgoera.Location = new System.Drawing.Point(30, 192);
            this.lblEgoera.Size = new System.Drawing.Size(860, 28);

            // ═══════════════════════════════════
            //  DATAGRIDVIEW
            // ═══════════════════════════════════
            this.dgvPartidak.Location = new System.Drawing.Point(30, 228);
            this.dgvPartidak.Size = new System.Drawing.Size(888, 330);
            this.dgvPartidak.BackgroundColor = panela;
            this.dgvPartidak.GridColor = System.Drawing.Color.FromArgb(62, 85, 108);
            this.dgvPartidak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPartidak.RowHeadersVisible = false;
            this.dgvPartidak.AllowUserToAddRows = false;
            this.dgvPartidak.AllowUserToDeleteRows = false;
            this.dgvPartidak.ReadOnly = true;
            this.dgvPartidak.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidak.Font = new System.Drawing.Font("Segoe UI", 10F);
            // Zelda estiloa
            this.dgvPartidak.DefaultCellStyle.BackColor = panela;
            this.dgvPartidak.DefaultCellStyle.ForeColor = testua;
            this.dgvPartidak.DefaultCellStyle.SelectionBackColor = berdea;
            this.dgvPartidak.DefaultCellStyle.SelectionForeColor = testua;
            this.dgvPartidak.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(58, 80, 100);
            // Header estiloa
            this.dgvPartidak.ColumnHeadersDefaultCellStyle.BackColor = iluna;
            this.dgvPartidak.ColumnHeadersDefaultCellStyle.ForeColor = testua;
            this.dgvPartidak.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvPartidak.ColumnHeadersHeight = 38;
            this.dgvPartidak.EnableHeadersVisualStyles = false;
            this.dgvPartidak.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // ═══════════════════════════════════
            //  ITXI BOTOIA
            // ═══════════════════════════════════
            this.btnItxi.Text = "✖  Itxi";
            this.btnItxi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnItxi.Location = new System.Drawing.Point(808, 578);
            this.btnItxi.Size = new System.Drawing.Size(110, 38);
            this.btnItxi.BackColor = gorria;
            this.btnItxi.ForeColor = testua;
            this.btnItxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItxi.FlatAppearance.BorderSize = 0;
            this.btnItxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);

            // ═══════════════════════════════════
            //  FORM EZARPENAK
            // ═══════════════════════════════════
            this.Text = "Zozketa - Mus Txapelketak";
            this.Size = new System.Drawing.Size(950, 650);
            this.BackColor = nagusia;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Load += new System.EventHandler(this.Zozketa_Load);

            // ═══════════════════════════════════
            //  KONTROLAK GEHITU
            // ═══════════════════════════════════
            this.Controls.Add(this.pnlGoikoa);
            this.Controls.Add(this.lblTxapLabel);
            this.Controls.Add(this.cmbTxapelketak);
            this.Controls.Add(this.btnEginZozketa);
            this.Controls.Add(this.lblEgoera);
            this.Controls.Add(this.dgvPartidak);
            this.Controls.Add(this.btnItxi);

            this.pnlGoikoa.ResumeLayout(false);
            this.pnlGoikoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidak)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Kontrolen deklarazioa ──────────────────────────────────
        private System.Windows.Forms.Panel pnlGoikoa;
        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblAzpitit;
        private System.Windows.Forms.Label lblTxapLabel;
        private System.Windows.Forms.ComboBox cmbTxapelketak;
        private System.Windows.Forms.Button btnEginZozketa;
        private System.Windows.Forms.Label lblEgoera;
        private System.Windows.Forms.DataGridView dgvPartidak;
        private System.Windows.Forms.Button btnItxi;
    }
}