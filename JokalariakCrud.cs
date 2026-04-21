using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class JokalariakCrud
    {
        private Konexioa konexioa = new Konexioa();

        // ==================== SELECT ====================
        // Jokalari guztiak datu basetik hartzen ditu eta DataTable bat itzultzen du
        public DataTable GetJokalariak()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return dt;

            try
            {
                string sql = "SELECT id, izena, abizena, emaila, pasahitza, telefonoa, herria FROM jokalariak";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea datuak kargatzerakoan:\n" + e.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        // ==================== INSERT ====================
        // Formularioko datuekin jokalari berri bat sortzen du eta datu basean txertatzen du
        public void TxertatuJokalaria(string izena, string abizena, string emaila,
                                      string telefonoa, string herria, string pasahitza)
        {
            // Lehenik objektua sortu konstruktorearekin
            Jokalariak jokalari = new Jokalariak(izena, abizena, emaila, telefonoa, herria, pasahitza);

            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"INSERT INTO jokalariak (izena, abizena, emaila, telefonoa, herria, pasahitza)
                               VALUES (@izena, @abizena, @emaila, @telefonoa, @herria, @pasahitza)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@abizena", abizena);
                cmd.Parameters.AddWithValue("@emaila", emaila);
                cmd.Parameters.AddWithValue("@telefonoa", telefonoa);
                cmd.Parameters.AddWithValue("@herria", herria);
                cmd.Parameters.AddWithValue("@pasahitza", pasahitza);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Jokalaria ondo txertatua!", "Arrakasta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea txertatzerakoan:\n" + e.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // ==================== UPDATE ====================
        // ID-aren bidez jokalari bat bilatzen du eta bere datuak eguneratzen ditu
        public void EguneratuJokalaria(int id, string izena, string abizena, string emaila,
                                       string telefonoa, string herria, string pasahitza)
        {
            // Objektua eguneratutako datuekin sortzen da
            Jokalariak jokalari = new Jokalariak(izena, abizena, emaila, telefonoa, herria, pasahitza);

            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"UPDATE jokalariak SET 
                izena = @izena, 
                abizena = @abizena, 
                emaila = @emaila, 
                telefonoa = @telefonoa, 
                herria = @herria, 
                pasahitza = @pasahitza
                WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@abizena", abizena);
                cmd.Parameters.AddWithValue("@emaila", emaila);
                cmd.Parameters.AddWithValue("@telefonoa", telefonoa);
                cmd.Parameters.AddWithValue("@herria", herria);
                cmd.Parameters.AddWithValue("@pasahitza", pasahitza);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Jokalaria ondo eguneratua!", "Arrakasta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea eguneratzerakoan:\n" + e.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // ==================== DELETE ====================
        // ID-aren bidez jokalari bat bilatzen du eta datu basetik ezabatzen du
        public void EzabatuJokalaria(int id)
        {
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = "DELETE FROM jokalariak WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Jokalaria ondo ezabatua!", "Arrakasta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea ezabatzerakoan:\n" + e.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}