using System;
using System.Drawing;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Dashboard : Form
    {
        private string rola;

        public Dashboard(string izena, string abizena, string rola)
        {
            InitializeComponent();
            this.rola = rola;

            lblUser.Text = izena + " " + abizena + " (" + rola + ")";
            PantailaKargatu(rola);
        }

        private void PantailaKargatu(string rola)
        {
            string[] pantailak;

            if (rola == "epailea")
            {
                pantailak = new string[] { "Txapelketak", "Partidak", "Sariak" };
            }
            else if (rola == "antolatzailea")
            {
                pantailak = new string[] {
                    "Txapelketak", "Partidak", "Jokalariak",
                    "Bikoteak", "Zozketa", "Rankinga", "Sariak"
                };
            }
            else if (rola == "kudeatzailea")
            {
                pantailak = new string[] {
                    "Txapelketak", "Partidak", "Jokalariak",
                    "Bikoteak", "Zozketa", "Rankinga",
                    "Langileak", "Sariak"
                };
            }
            else return;

            int x = 50, y = 90;
            int w = 210, h = 80;
            int gapX = 20, gapY = 20;
            int col = 0, colMax = 3;

            foreach (string pantaila in pantailak)
            {
                Button btn = new Button
                {
                    Text = pantaila.ToUpper(),
                    Tag = pantaila,
                    Size = new Size(w, h),
                    Location = new Point(x, y),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.FromArgb(52, 152, 219),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.Click += Botoia_Click;
                Controls.Add(btn);

                col++;
                if (col >= colMax)
                {
                    col = 0;
                    x = 50;
                    y += h + gapY;
                }
                else
                {
                    x += w + gapX;
                }
            }
        }

        private void Botoia_Click(object sender, EventArgs e)
        {
            string pantaila = ((Button)sender).Tag.ToString();

            if (pantaila == "Txapelketak")
                new Txapelketak(rola).ShowDialog();  
            else if (pantaila == "Partidak")
                new Partidak().ShowDialog();
            else if (pantaila == "Jokalariak")
                new Jokalariak().ShowDialog();
            else if (pantaila == "Bikoteak")
                new Bikoteak().ShowDialog();
            else if (pantaila == "Zozketa")
                new Zozketa().ShowDialog();
            else if (pantaila == "Rankinga")
                new Ranking().ShowDialog();
            else if (pantaila == "Langileak")
                new Langileak().ShowDialog();
            else if (pantaila == "Sariak")
                new Sariak().ShowDialog();
        }
    }
}