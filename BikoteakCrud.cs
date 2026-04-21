using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class BikoteakCrud
    {
        private Konexioa konexioa = new Konexioa();

        // ==================== SELECT ====================
        public DataTable GetBikoteak()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return dt;

            try
            {
                string sql = @"SELECT id, jokalaria1_id, jokalaria2_id, ezizena
                               FROM bikoteak";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea datuak kargatzerakoan:\n" + e.Message,
                    "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        // ==================== INSERT ====================
        public void TxertatuBikotea(int jokalaria1Id, int jokalaria2Id, string ezizena)
        {
            // ✅ Jokalariak bezala: objektua sortu
            Bikoteak bikote = new Bikoteak(jokalaria1Id, jokalaria2Id, ezizena);

            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"INSERT INTO bikoteak
                               (jokalaria1_id, jokalaria2_id, ezizena)
                               VALUES (@j1, @j2, @ezizena)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@j1", jokalaria1Id);
                cmd.Parameters.AddWithValue("@j2", jokalaria2Id);
                cmd.Parameters.AddWithValue("@ezizena", ezizena);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Bikotea ondo txertatua!", "Arrakasta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea txertatzerakoan:\n" + e.Message,
                    "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // ==================== UPDATE ====================
        public void EguneratuBikotea(int id, int jokalaria1Id, int jokalaria2Id, string ezizena)
        {
            // ✅ Objektua berriro sortzen da (Jokalariak bezalaxe)
            Bikoteak bikote = new Bikoteak(id, jokalaria1Id, jokalaria2Id, ezizena);

            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"UPDATE bikoteak SET
                               jokalaria1_id = @j1,
                               jokalaria2_id = @j2,
                               ezizena = @ezizena
                               WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@j1", jokalaria1Id);
                cmd.Parameters.AddWithValue("@j2", jokalaria2Id);
                cmd.Parameters.AddWithValue("@ezizena", ezizena);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Bikotea ondo eguneratua!", "Arrakasta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea eguneratzerakoan:\n" + e.Message,
                    "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // ==================== DELETE ====================
        public void EzabatuBikotea(int id)
        {
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = "DELETE FROM bikoteak WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Bikotea ondo ezabatua!", "Arrakasta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea ezabatzerakoan:\n" + e.Message,
                    "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}