using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class TxapelketakCrud
    {
        private Konexioa konexioa = new Konexioa();

        // ==================== SELECT ====================
        public DataTable GetTxapelketak()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return dt;

            try
            {
                string sql = @"SELECT id, izena, herria, tokia, egoera, bikote_kant, data
                               FROM txapelketak";

                new MySqlDataAdapter(sql, con).Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea datuak kargatzerakoan:\n" + e.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        // ==================== INSERT ====================
        public void TxertatuTxapelketa(string izena, string herria, string tokia,
                                       string egoera, int bikoteKant, DateTime data)
        {
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"INSERT INTO txapelketak
                               (izena, herria, tokia, egoera, bikote_kant, data)
                               VALUES (@izena, @herria, @tokia, @egoera, @bikote, @data)";

                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@herria", herria);
                cmd.Parameters.AddWithValue("@tokia", tokia);
                cmd.Parameters.AddWithValue("@egoera", egoera);
                cmd.Parameters.AddWithValue("@bikote", bikoteKant);
                cmd.Parameters.AddWithValue("@data", data);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Txapelketa ondo txertatua!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea txertatzerakoan:\n" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ==================== UPDATE ====================
        public void EguneratuTxapelketa(int id, string izena, string herria,
                                        string tokia, string egoera,
                                        int bikoteKant, DateTime data)
        {
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = @"UPDATE txapelketak SET
                               izena=@izena,
                               herria=@herria,
                               tokia=@tokia,
                               egoera=@egoera,
                               bikote_kant=@bikote,
                               data=@data
                               WHERE id=@id";

                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@herria", herria);
                cmd.Parameters.AddWithValue("@tokia", tokia);
                cmd.Parameters.AddWithValue("@egoera", egoera);
                cmd.Parameters.AddWithValue("@bikote", bikoteKant);
                cmd.Parameters.AddWithValue("@data", data);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Txapelketa ondo eguneratua!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea eguneratzerakoan:\n" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // ==================== DELETE ====================
        public void EzabatuTxapelketa(int id)
        {
            MySqlConnection con = konexioa.getConnection();
            if (con == null) return;

            try
            {
                string sql = "DELETE FROM txapelketak WHERE id=@id";
                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Txapelketa ondo ezabatua!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea ezabatzerakoan:\n" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}