using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class LangileakCrud
    {
        private Konexioa konexioa = new Konexioa();

        // ==================== SELECT ====================
        public DataTable GetLangileak()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return dt;

            try
            {
                string sql = @"SELECT id, izena, abizena, emaila, telefonoa, rola
                               FROM langileak";

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
        public void TxertatuLangilea(string izena, string abizena, string emaila,
                                     string telefonoa, string rola)
        {
            // ✅ Jokalariak bezalaxe: objektua sortu
            Langileak langilea = new Langileak(izena, abizena, emaila, telefonoa, rola);

            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"INSERT INTO langileak
                               (izena, abizena, emaila, telefonoa, rola)
                               VALUES (@izena, @abizena, @emaila, @telefonoa, @rola)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@abizena", abizena);
                cmd.Parameters.AddWithValue("@emaila", emaila);
                cmd.Parameters.AddWithValue("@telefonoa", telefonoa);
                cmd.Parameters.AddWithValue("@rola", rola);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Langilea ondo txertatua!", "Arrakasta",
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
        public void EguneratuLangilea(int id, string izena, string abizena, string emaila,
                                      string telefonoa, string rola)
        {
            // ✅ Objektua berriro sortzen da (eredu berdina)
            Langileak langilea = new Langileak(izena, abizena, emaila, telefonoa, rola);

            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"UPDATE langileak SET
                               izena = @izena,
                               abizena = @abizena,
                               emaila = @emaila,
                               telefonoa = @telefonoa,
                               rola = @rola
                               WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@abizena", abizena);
                cmd.Parameters.AddWithValue("@emaila", emaila);
                cmd.Parameters.AddWithValue("@telefonoa", telefonoa);
                cmd.Parameters.AddWithValue("@rola", rola);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Langilea ondo eguneratua!", "Arrakasta",
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
        public void EzabatuLangilea(int id)
        {
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = "DELETE FROM langileak WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Langilea ondo ezabatua!", "Arrakasta",
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