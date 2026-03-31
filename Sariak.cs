using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public partial class Sariak : Form
    {
        private string XML_PATH = @"C:\xampp\htdocs\3ERRONKA\WEB\XML\sariak.xml";

        public Sariak()
        {
            InitializeComponent();
            TxapelketakKargatu();
        }

        // ── MySQL-etik txapelketak kargatu ──────────────────
        private void TxapelketakKargatu()
        {
            try
            {
                MySqlConnection cn = new Konexioa().getConnection();
                if (cn == null) return;

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT id, izena FROM txapelketak", cn);
                MySqlDataReader rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    cmbTxapelketa.Items.Add(
                        rs.GetInt32("id") + "|" + rs.GetString("izena"));
                }

                rs.Close();
                cn.Close();

                
                cmbTxapelketa.Format += (s, e) =>
                {
                    string[] zatiak = e.ListItem.ToString().Split('|');
                    e.Value = zatiak[1];
                };
                cmbTxapelketa.FormattingEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea txapelketak kargatzerakoan:\n" + ex.Message);
            }
        }

        // ── Gorde botoian klik ─────────────────────────────────────────
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (cmbTxapelketa.SelectedItem == null)
            {
                MessageBox.Show("Hautatu txapelketa bat.", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] zatiak = cmbTxapelketa.SelectedItem.ToString().Split('|');
            string txapIzena = zatiak[1];

            GordeXMLn(txapIzena);

            MessageBox.Show("Sariak gordeta!", "Ondo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── XML-en gorde ─────────────────────────────────────────────────
        private void GordeXMLn(string txapIzena)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                doc.Load(XML_PATH);

                XmlElement erroa = doc.DocumentElement;

                // Aukeratutako txapelketa badago ezabatu
                XmlNode zaharra = erroa.SelectSingleNode(
                    "txapelketa[@izena='" + txapIzena + "']");
                if (zaharra != null)
                    erroa.RemoveChild(zaharra);

                // Txapelketa berria
                XmlElement txapelketa = doc.CreateElement("txapelketa");
                txapelketa.SetAttribute("izena", txapIzena);

                // Sariak nodo
                XmlElement sariak = doc.CreateElement("sariak");

                // TextBox bakoitza — hutsak saltu
                string[] testuak = { txt1.Text, txt2.Text, txt3.Text, txt4_10.Text };
                string[] postuak = { "1", "2", "3", "4 - 10" };

                for (int i = 0; i < testuak.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(testuak[i])) continue;

                    // <saria
                    XmlElement saria = doc.CreateElement("saria");

                    // <posizioa>
                    XmlElement posizioa = doc.CreateElement("posizioa");
                    posizioa.InnerText = postuak[i];

                    // <deskribapena>
                    XmlElement deskripzioa = doc.CreateElement("deskribapena");
                    deskripzioa.InnerText = testuak[i].Trim();

                    saria.AppendChild(posizioa);
                    saria.AppendChild(deskripzioa);
                    sariak.AppendChild(saria);
                }

                txapelketa.AppendChild(sariak);
                erroa.AppendChild(txapelketa);

                // Indentazioa eduki dezan
                XmlWriterSettings ezarpenak = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "  "
                };
                using (XmlWriter idazlea = XmlWriter.Create(XML_PATH, ezarpenak))
                {
                    doc.Save(idazlea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML errorea:\n" + ex.Message);
            }
        }
    }
}
