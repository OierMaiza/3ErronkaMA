using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Dashboard : Form
    {
        public Dashboard(string izena, string abizena, string rola)
        {
            InitializeComponent();
            lblUser.Text = izena + " " + abizena + " (" + rola + ")";
            PantailaKargatu(rola);
        }

        private void PantailaKargatu(string rola)
        {
            // Rol bakoitzaren pantailak definitu
            string[] pantailak;

            if (rola == "epailea")
            {
                pantailak = new string[] { "Txapelketak", "Partidak" };
            }
            else if (rola == "antolatzailea")
            {
                pantailak = new string[] { "Txapelketak", "Partidak", "Txapelketa Kudeaketa", "Jokalariak", "Bikoteak", "Zozketa", "Sailkapena" };
            }
            else if (rola == "kudeatzailea")
            {
                pantailak = new string[] { "Txapelketak", "Partidak", "Txapelketa Kudeaketa", "Jokalariak", "Bikoteak", "Zozketa", "Sailkapena", "Langileak" };
            }
            else
            {
                return; // Rola ezezaguna, ezer ez egin
            }

            // Botoien kokapena eta tamaina
            int x = 50;
            int y = 90;
            int zabalera = 210;
            int altuera = 80;
            int zuriuneX = 20;
            int zuriuneY = 20;
            int zutabeMax = 3;
            int zutabe = 0;

            foreach (string pantaila in pantailak)
            {
                Button btn = new Button();
                btn.Text = pantaila.ToUpper();
                btn.Name = "btn_" + pantaila.Replace(" ", "_");
                btn.Tag = pantaila;
                btn.Size = new Size(zabalera, altuera);
                btn.Location = new Point(x, y);
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.BackColor = Color.FromArgb(52, 152, 219);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Click += Botoia_Click;

                this.Controls.Add(btn);

                // Hurrengo botoia non jarri
                zutabe++;
                if (zutabe >= zutabeMax)
                {
                    zutabe = 0;
                    x = 50;
                    y += altuera + zuriuneY;
                }
                else
                {
                    x += zabalera + zuriuneX;
                }
            }
        }

        private void Botoia_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string pantaila = btn.Tag.ToString();

            // Geroago hemen bakoitzaren Form-a irekiko duzu:
            // if (pantaila == "Jokalariak")          new FJokalariak().ShowDialog();
            // if (pantaila == "Txapelketak")         new FTxapelketak().ShowDialog();
            // if (pantaila == "Txapelketa Kudeaketa") new FTxapelketaKudeaketa().ShowDialog();
            // if (pantaila == "Bikoteak")             new FBikoteak().ShowDialog();
            // if (pantaila == "Zozketa")              new FZozketa().ShowDialog();
            // if (pantaila == "Sailkapena")           new FSailkapena().ShowDialog();
            // if (pantaila == "Langileak")            new FLangileak().ShowDialog();
            // if (pantaila == "Partidak")             new FPartidak().ShowDialog();

            MessageBox.Show(pantaila + " — laster egingo dugu!",
                "TODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}