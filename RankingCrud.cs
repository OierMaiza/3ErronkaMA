using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class RankingCrud
    {
        private Konexioa konexioa = new Konexioa();

        // ==================== SELECT ====================
        public DataTable GetRanking()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return dt;

            try
            {
                string sql = @"
                SELECT r.id,
                       j.izena AS jokalaria,
                       r.jokatutako_partidak,
                       r.irabazitako_partidak,
                       r.galdutako_partidak
                FROM ranking r
                JOIN jokalariak j ON r.jokalaria_id = j.id
                ORDER BY r.irabazitako_partidak DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Errorea ranking‑a kargatzerakoan:\n" + e.Message,
                    "Errorea",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}