using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public (string rola, string izena, string abizena) login()
        {
            string email = textBox1.Text;
            string pasahitza = textBox2.Text;

            if (email == "" || pasahitza == "") return (null, null, null);

            string rola = null;
            string izena = "";
            string abizena = "";

            try
            {
                MySqlConnection cn = new Konexioa().getConnection();

                if (cn == null)
                {
                    MessageBox.Show("Ezin izan da MySQL-era konektatu", "Errorea",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (null, null, null);
                }

                MySqlCommand ps = new MySqlCommand(
                    "SELECT * FROM langileak WHERE emaila = @email AND pasahitza = @pasahitza", cn);
                ps.Parameters.AddWithValue("@email", email);
                ps.Parameters.AddWithValue("@pasahitza", pasahitza);

                MySqlDataReader rs = ps.ExecuteReader();

                if (rs.Read())
                {
                    rola = rs.GetString("rola");
                    izena = rs.GetString("izena");
                    abizena = rs.GetString("abizena");
                }
                else
                {
                    rs.Close();
                    cn.Close();
                    return (null, null, null);
                }

                rs.Close();
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea login egitean:\n" + e.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (rola, izena, abizena);
            

        }

        // ── Botoia sakatzean ────────────────────────────────────
        private void button1_Click(object sender, EventArgs e)
        {
            // Hutsak egiaztatu
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Email-a eta pasahitza bete ezazu.", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (rola, izena, abizena) = login();

            if (rola != null)
            {
                // Ondo — Dashboard ireki
                Dashboard dashboard = new Dashboard(izena, abizena, rola);
                dashboard.ShowDialog();
                this.Hide();
            }
            else
            {
                // Gaizki — errorea
                MessageBox.Show("Email-a edo pasahitza okerra da.\nSaiatu berriro.", "Sarrera ukatu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}