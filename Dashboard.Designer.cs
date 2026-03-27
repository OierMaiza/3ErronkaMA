namespace EuskalMus
{
    partial class Dashboard
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
            this.pnlGoikoBarra = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();

            // ── GOIKO BARRA ──────────────────────────────────────────────
            this.pnlGoikoBarra.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlGoikoBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGoikoBarra.Height = 60;
            this.pnlGoikoBarra.Name = "pnlGoikoBarra";

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 15);
            this.lblLogo.Text = "EuskalMus";

            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblUser.Location = new System.Drawing.Point(525, 20);
            this.lblUser.Text = "";

            this.pnlGoikoBarra.Controls.Add(this.lblLogo);
            this.pnlGoikoBarra.Controls.Add(this.lblUser);

            // ── FORMULARIOA ──────────────────────────────────────────────
            this.Text = "EuskalMus - Dashboard";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.Controls.Add(this.pnlGoikoBarra);
        }

        // ── Kontrolen deklarazioa ────────────────────────────────────────
        private System.Windows.Forms.Panel pnlGoikoBarra;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblUser;
    }
}