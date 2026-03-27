using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.pnlGoikoBarra = new Panel();
            this.lblLogo = new Label();
            this.lblUser = new Label();
            this.btnTxapelketak = new Button();
            this.btnJokalariak = new Button();
            this.btnBikoteak = new Button();
            this.btnZozketa = new Button();
            this.btnPartidak = new Button();

            // ── Formulario ───────────────────────────────────────────────
            this.Text = "EuskalMus - Dashboard";
            this.Size = new System.Drawing.Size(850, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            // ── Barra superior ───────────────────────────────────────────
            this.pnlGoikoBarra.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlGoikoBarra.Dock = DockStyle.Top;
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
            this.lblUser.Location = new System.Drawing.Point(600, 20);
            this.lblUser.Text = "Erabiltzailea";

            this.pnlGoikoBarra.Controls.Add(this.lblLogo);
            this.pnlGoikoBarra.Controls.Add(this.lblUser);

            // ── Botones ──────────────────────────────────────────────────
            // 1. Txapelketak
            this.btnTxapelketak.Location = new System.Drawing.Point(50, 100);
            this.btnTxapelketak.Size = new System.Drawing.Size(220, 90);
            this.btnTxapelketak.Text = "TXAPELKETAK";
            this.btnTxapelketak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTxapelketak.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnTxapelketak.ForeColor = System.Drawing.Color.White;
            this.btnTxapelketak.FlatStyle = FlatStyle.Flat;
            this.btnTxapelketak.FlatAppearance.BorderSize = 0;

            // 2. Jokalariak
            this.btnJokalariak.Location = new System.Drawing.Point(300, 100);
            this.btnJokalariak.Size = new System.Drawing.Size(220, 90);
            this.btnJokalariak.Text = "JOKALARIAK";
            this.btnJokalariak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnJokalariak.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnJokalariak.ForeColor = System.Drawing.Color.White;
            this.btnJokalariak.FlatStyle = FlatStyle.Flat;
            this.btnJokalariak.FlatAppearance.BorderSize = 0;

            // 3. Bikoteak
            this.btnBikoteak.Location = new System.Drawing.Point(550, 100);
            this.btnBikoteak.Size = new System.Drawing.Size(220, 90);
            this.btnBikoteak.Text = "BIKOTEAK";
            this.btnBikoteak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBikoteak.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnBikoteak.ForeColor = System.Drawing.Color.White;
            this.btnBikoteak.FlatStyle = FlatStyle.Flat;
            this.btnBikoteak.FlatAppearance.BorderSize = 0;

            // 4. Zozketa
            this.btnZozketa.Location = new System.Drawing.Point(50, 220);
            this.btnZozketa.Size = new System.Drawing.Size(220, 90);
            this.btnZozketa.Text = "ZOZKETA";
            this.btnZozketa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnZozketa.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnZozketa.ForeColor = System.Drawing.Color.White;
            this.btnZozketa.FlatStyle = FlatStyle.Flat;
            this.btnZozketa.FlatAppearance.BorderSize = 0;

            // 5. Partidak
            this.btnPartidak.Location = new System.Drawing.Point(300, 220);
            this.btnPartidak.Size = new System.Drawing.Size(220, 90);
            this.btnPartidak.Text = "PARTIDAK";
            this.btnPartidak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPartidak.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnPartidak.ForeColor = System.Drawing.Color.White;
            this.btnPartidak.FlatStyle = FlatStyle.Flat;
            this.btnPartidak.FlatAppearance.BorderSize = 0;

            // ── Añadir controles al formulario ───────────────────────────
            this.Controls.Add(this.pnlGoikoBarra);
            this.Controls.Add(this.btnTxapelketak);
            this.Controls.Add(this.btnJokalariak);
            this.Controls.Add(this.btnBikoteak);
            this.Controls.Add(this.btnZozketa);
            this.Controls.Add(this.btnPartidak);
        }
    }
}
