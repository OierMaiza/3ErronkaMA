namespace EuskalMus
{
    partial class Ranking
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
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.lblTitulua = new System.Windows.Forms.Label();
            this.btnKargatu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRanking
            // 
            this.dgvRanking.BackgroundColor = System.Drawing.Color.White;
            this.dgvRanking.ColumnHeadersHeight = 29;
            this.dgvRanking.Location = new System.Drawing.Point(30, 80);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.ReadOnly = true;
            this.dgvRanking.RowHeadersWidth = 51;
            this.dgvRanking.Size = new System.Drawing.Size(857, 320);
            this.dgvRanking.TabIndex = 0;
            // 
            // lblTitulua
            // 
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulua.Location = new System.Drawing.Point(30, 20);
            this.lblTitulua.Name = "lblTitulua";
            this.lblTitulua.Size = new System.Drawing.Size(400, 40);
            this.lblTitulua.TabIndex = 1;
            this.lblTitulua.Text = "RANKING-A KUDEATU";
            // 
            // btnKargatu
            // 
            this.btnKargatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnKargatu.FlatAppearance.BorderSize = 0;
            this.btnKargatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKargatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKargatu.ForeColor = System.Drawing.Color.White;
            this.btnKargatu.Location = new System.Drawing.Point(30, 420);
            this.btnKargatu.Name = "btnKargatu";
            this.btnKargatu.Size = new System.Drawing.Size(120, 45);
            this.btnKargatu.TabIndex = 2;
            this.btnKargatu.Text = "KARGATU";
            this.btnKargatu.UseVisualStyleBackColor = false;
            // 
            // Ranking
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.dgvRanking);
            this.Controls.Add(this.lblTitulua);
            this.Controls.Add(this.btnKargatu);
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuskalMus - Ranking-a Kudeatu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.ResumeLayout(false);

        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.Label lblTitulua; 
        private System.Windows.Forms.Button btnKargatu;
    }
}