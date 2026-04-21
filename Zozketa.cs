using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public partial class Zozketa : Form
    {
        public Zozketa()
        {
            InitializeComponent();
        }

        // ── Forma kargatzean txapelketak kargatu ─────────────────
        private void Zozketa_Load(object sender, EventArgs e)
        {
            TxapelketakKargatu();
        }

        // ── Txapelketak kargatu ComboBox-era ─────────────────────
        private void TxapelketakKargatu()
        {
            try
            {
                MySqlConnection cn = new Konexioa().getConnection();
                if (cn == null) return;

                string sql = "SELECT id, izena FROM txapelketak ORDER BY data ASC";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataReader rs = cmd.ExecuteReader();

                cmbTxapelketak.Items.Clear();
                while (rs.Read())
                    cmbTxapelketak.Items.Add(
                        rs.GetInt32("id") + "|" + rs.GetString("izena"));

                rs.Close();
                cn.Close();

                // ComboBox-ean izena bakarrik erakutsi
                cmbTxapelketak.Format += (s, ev) =>
                {
                    ev.Value = ev.ListItem.ToString().Split('|')[1];
                };
                cmbTxapelketak.FormattingEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea txapelketak kargatzerakoan:\n" + ex.Message);
            }
        }

        // ── Zozketa Egin botoia ───────────────────────────────────
        private void btnEginZozketa_Click(object sender, EventArgs e)
        {
            if (cmbTxapelketak.SelectedItem == null)
            {
                MessageBox.Show("Hautatu txapelketa bat.", "Oharra",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] zatiak = cmbTxapelketak.SelectedItem.ToString().Split('|');
            int txapelketaId = int.Parse(zatiak[0]);
            string txapIzena = zatiak[1];

            // Zozketa eginda dagoen egiaztatu
            if (ZozketaEgindaDago(txapelketaId))
            {
                // Dagoeneko eginda → bracket erakutsi
                lblEgoera.Text = "⚠️ Txapelketa honetako zozketa eginda dago.";
                BracketKargatu(txapelketaId);
                return;
            }

            // Bikoteak egon behar dira apuntatuta
            List<int> bikoteIds = BikoteakLortu(txapelketaId);
            if (bikoteIds.Count < 2)
            {
                MessageBox.Show("Gutxienez 2 bikote apuntatu behar dira.", "Oharra",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirm = MessageBox.Show(
                txapIzena + " txapelketako zozketa egin nahi duzu?\n" +
                bikoteIds.Count + " bikote daude apuntatuta.",
                "Berretsi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirm != DialogResult.Yes) return;

            // Zozketa egin
            ZozketaEgin(txapelketaId, bikoteIds);
        }

        // ── Zozketa eginda dagoen egiaztatu ──────────────────────
        private bool ZozketaEgindaDago(int txapelketaId)
        {
            try
            {
                MySqlConnection cn = new Konexioa().getConnection();
                if (cn == null) return false;

                string sql = "SELECT COUNT(*) FROM partidak WHERE txapelketa_id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", txapelketaId);
                int kopurua = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                return kopurua > 0;
            }
            catch { return false; }
        }

        // ── Apuntatutako bikoteak lortu ───────────────────────────
        private List<int> BikoteakLortu(int txapelketaId)
        {
            List<int> bikoteIds = new List<int>();
            try
            {
                MySqlConnection cn = new Konexioa().getConnection();
                if (cn == null) return bikoteIds;

                string sql = "SELECT bikotea_id FROM txapelketa_bikoteak " +
                             "WHERE txapelketa_id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", txapelketaId);
                MySqlDataReader rs = cmd.ExecuteReader();

                while (rs.Read())
                    bikoteIds.Add(rs.GetInt32("bikotea_id"));

                rs.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea bikoteak kargatzerakoan:\n" + ex.Message);
            }
            return bikoteIds;
        }

        // ── Zozketa egin, faseak eta partidak sortu ───────────────
        private void ZozketaEgin(int txapelketaId, List<int> bikoteIds)
        {
            try
            {
                // 1. Ausaz nahastu
                AusazNahastu(bikoteIds);

                MySqlConnection cn = new Konexioa().getConnection();
                if (cn == null) return;

                // 2. 1. fasea sortu
                string sqlFase = "INSERT INTO faseak (txapelketa_id, fase_zenbakia) " +
                                 "VALUES (@txapId, 1)";
                MySqlCommand cmdFase = new MySqlCommand(sqlFase, cn);
                cmdFase.Parameters.AddWithValue("@txapId", txapelketaId);
                cmdFase.ExecuteNonQuery();
                int faseId = Convert.ToInt32(cmdFase.LastInsertedId);

                // 3. Partidak sortu binaka
                dgvPartidak.Rows.Clear();
                dgvPartidak.Columns.Clear();
                dgvPartidak.Columns.Add("partida", "Partida");
                dgvPartidak.Columns.Add("bikoteA", "Bikote A");
                dgvPartidak.Columns.Add("vs", "VS");
                dgvPartidak.Columns.Add("bikoteB", "Bikote B");
                dgvPartidak.Columns["vs"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.None;
                dgvPartidak.Columns["vs"].Width = 40;

                int posizioa = 0;
                for (int i = 0; i < bikoteIds.Count - 1; i += 2)
                {
                    int bikoteA = bikoteIds[i];
                    int bikoteB = bikoteIds[i + 1];

                    // Partida datu-basean gorde
                    string sqlPartida =
                        "INSERT INTO partidak " +
                        "(txapelketa_id, fase_id, posizioa, bikoteA_id, bikoteB_id, egoera) " +
                        "VALUES (@txapId, @faseId, @pos, @bA, @bB, 'zain')";
                    MySqlCommand cmd = new MySqlCommand(sqlPartida, cn);
                    cmd.Parameters.AddWithValue("@txapId", txapelketaId);
                    cmd.Parameters.AddWithValue("@faseId", faseId);
                    cmd.Parameters.AddWithValue("@pos", posizioa);
                    cmd.Parameters.AddWithValue("@bA", bikoteA);
                    cmd.Parameters.AddWithValue("@bB", bikoteB);
                    cmd.ExecuteNonQuery();

                    // Taulan erakutsi
                    dgvPartidak.Rows.Add(
                        "Partida " + (posizioa + 1),
                        BikoterIzenaLortu(bikoteA, cn),
                        "VS",
                        BikoterIzenaLortu(bikoteB, cn));

                    posizioa++;
                }

                cn.Close();

                lblEgoera.Text = "✅ Zozketa ongi egin da! " +
                                 posizioa + " partida sortu dira.";

                MessageBox.Show("Zozketa ongi egin da!\n" + posizioa + " partida sortu dira.",
                    "Ondo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea zozketa egiterakoan:\n" + ex.Message);
            }
        }

        // ── Dagoeneko egindako bracket kargatu ────────────────────
        private void BracketKargatu(int txapelketaId)
        {
            try
            {
                MySqlConnection cn = new Konexioa().getConnection();
                if (cn == null) return;

                string sql =
                    "SELECT p.posizioa, bA.ezizena AS bAIzena, bB.ezizena AS bBIzena " +
                    "FROM partidak p " +
                    "JOIN faseak f ON p.fase_id = f.id " +
                    "LEFT JOIN bikoteak bA ON p.bikoteA_id = bA.id " +
                    "LEFT JOIN bikoteak bB ON p.bikoteB_id = bB.id " +
                    "WHERE p.txapelketa_id = @txapId AND f.fase_zenbakia = 1 " +
                    "ORDER BY p.posizioa";

                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@txapId", txapelketaId);
                MySqlDataReader rs = cmd.ExecuteReader();

                dgvPartidak.Rows.Clear();
                dgvPartidak.Columns.Clear();
                dgvPartidak.Columns.Add("partida", "Partida");
                dgvPartidak.Columns.Add("bikoteA", "Bikote A");
                dgvPartidak.Columns.Add("vs", "VS");
                dgvPartidak.Columns.Add("bikoteB", "Bikote B");
                dgvPartidak.Columns["vs"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.None;
                dgvPartidak.Columns["vs"].Width = 40;

                while (rs.Read())
                {
                    dgvPartidak.Rows.Add(
                        "Partida " + (rs.GetInt32("posizioa") + 1),
                        rs["bAIzena"].ToString(),
                        "VS",
                        rs["bBIzena"].ToString());
                }

                rs.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea bracket kargatzerakoan:\n" + ex.Message);
            }
        }

        // ── Bikote baten izena lortu ──────────────────────────────
        private string BikoterIzenaLortu(int bikoteId, MySqlConnection cn)
        {
            try
            {
                string sql = "SELECT ezizena FROM bikoteak WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", bikoteId);
                object emaitza = cmd.ExecuteScalar();
                return emaitza != null ? emaitza.ToString() : "—";
            }
            catch { return "—"; }
        }

        // ── Fisher-Yates ausaz nahasketa ──────────────────────────
        private void AusazNahastu(List<int> lista)
        {
            Random rnd = new Random();
            for (int i = lista.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                int tmp = lista[i];
                lista[i] = lista[j];
                lista[j] = tmp;
            }
        }

        // ── Itxi botoia ───────────────────────────────────────────
        private void btnItxi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}