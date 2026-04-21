using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class PartidakCrud
    {
        private Konexioa konexioa = new Konexioa();

        // ==================== SELECT ====================
        public DataTable GetPartidak()
        {
            DataTable dt = new DataTable();
            var con = konexioa.getConnection();
            if (con == null) return dt;

            try
            {
                string sql = @"
                SELECT
                    p.id,
                    p.txapelketa_id,
                    f.fase_zenbakia AS faseZenbakia,
                    p.posizioa,
                    p.bikoteA_id   AS bikoteaA,
                    p.bikoteB_id   AS bikoteaB,
                    p.irabazlea_id,
                    p.galtzailea_id,
                    p.egoera
                FROM partidak p
                INNER JOIN faseak f ON p.fase_id = f.id
                ORDER BY f.fase_zenbakia, p.posizioa";

                new MySqlDataAdapter(sql, con).Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errorea partidak kargatzerakoan:\n" + e.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        // ==================== UPDATE (ZUHATZAREN LOGIKA OSOA) ====================
        public void EguneratuPartida(int partidaId, int irabazlea, int galtzailea)
        {
            var con = konexioa.getConnection();
            if (con == null) return;

            var tx = con.BeginTransaction();

            try
            {
                // 1️⃣ Uneko partidaren informazioa
                string sqlInfo = @"
            SELECT p.txapelketa_id, p.fase_id, f.fase_zenbakia, p.posizioa
            FROM partidak p
            INNER JOIN faseak f ON p.fase_id = f.id
            WHERE p.id = @id";

                var cmdInfo = new MySqlCommand(sqlInfo, con, tx);
                cmdInfo.Parameters.AddWithValue("@id", partidaId);

                int txapelketaId, faseId, faseZenbakia, posizioa;
                using (var r = cmdInfo.ExecuteReader())
                {
                    if (!r.Read()) throw new Exception("Partida ez da aurkitu");

                    txapelketaId = r.GetInt32("txapelketa_id");
                    faseId = r.GetInt32("fase_id");
                    faseZenbakia = r.GetInt32("fase_zenbakia");
                    posizioa = r.GetInt32("posizioa");
                }

                // Uneko partida eguneratu
                var cmdUpd = new MySqlCommand(@"
            UPDATE partidak SET
                irabazlea_id=@irab,
                galtzailea_id=@gal,
                egoera='Jokatuta'
            WHERE id=@id", con, tx);

                cmdUpd.Parameters.AddWithValue("@irab", irabazlea);
                cmdUpd.Parameters.AddWithValue("@gal", galtzailea);
                cmdUpd.Parameters.AddWithValue("@id", partidaId);
                cmdUpd.ExecuteNonQuery();

                // Finala den begiratu (fase honetan partida 1 bakarrik badago)
                var cmdCount = new MySqlCommand(
                    "SELECT COUNT(*) FROM partidak WHERE fase_id=@fase",
                    con, tx);
                cmdCount.Parameters.AddWithValue("@fase", faseId);

                int partidaKop = Convert.ToInt32(cmdCount.ExecuteScalar());
                if (partidaKop == 1)
                {
                    var cmdFinal = new MySqlCommand(
                        "UPDATE partidak SET egoera='FINAL' WHERE id=@id",
                        con, tx);
                    cmdFinal.Parameters.AddWithValue("@id", partidaId);
                    cmdFinal.ExecuteNonQuery();

                    tx.Commit();
                    MessageBox.Show("FINAL amaituta");
                    return;
                }

                // Hurrengo fasearen zenbakia
                int hurrengoFaseZenb = faseZenbakia + 1;
                int hurrengoPos = posizioa / 2;
                bool joanA = posizioa % 2 == 0;

                // Hurrengo fasearen IDa
                var cmdFase = new MySqlCommand(@"
            SELECT id FROM faseak
            WHERE txapelketa_id=@tx AND fase_zenbakia=@fz",
                    con, tx);

                cmdFase.Parameters.AddWithValue("@tx", txapelketaId);
                cmdFase.Parameters.AddWithValue("@fz", hurrengoFaseZenb);

                object faseObj = cmdFase.ExecuteScalar();
                int hurrengoFaseId;

                if (faseObj == null)
                {
                    var cmdInsertFase = new MySqlCommand(@"
                INSERT INTO faseak (txapelketa_id, fase_zenbakia)
                VALUES (@tx, @fz)", con, tx);

                    cmdInsertFase.Parameters.AddWithValue("@tx", txapelketaId);
                    cmdInsertFase.Parameters.AddWithValue("@fz", hurrengoFaseZenb);
                    cmdInsertFase.ExecuteNonQuery();

                    hurrengoFaseId = (int)cmdInsertFase.LastInsertedId;

                    // Partidak sortu fase berrian
                    int partidaBerriak = partidaKop / 2;
                    for (int i = 0; i < partidaBerriak; i++)
                    {
                        var cmdPartida = new MySqlCommand(@"
                    INSERT INTO partidak
                    (txapelketa_id, fase_id, posizioa, egoera)
                    VALUES (@tx, @fase, @pos, 'zain')",
                            con, tx);

                        cmdPartida.Parameters.AddWithValue("@tx", txapelketaId);
                        cmdPartida.Parameters.AddWithValue("@fase", hurrengoFaseId);
                        cmdPartida.Parameters.AddWithValue("@pos", i);
                        cmdPartida.ExecuteNonQuery();
                    }
                }
                else
                {
                    hurrengoFaseId = Convert.ToInt32(faseObj);
                }

                // Irabazlea DAGOKION PARTIDAN SARTU
                string zutabea = joanA ? "bikoteA_id" : "bikoteB_id";

                var cmdMove = new MySqlCommand($@"
            UPDATE partidak SET {zutabea}=@irab
            WHERE fase_id=@fase AND posizioa=@pos",
                    con, tx);

                cmdMove.Parameters.AddWithValue("@irab", irabazlea);
                cmdMove.Parameters.AddWithValue("@fase", hurrengoFaseId);
                cmdMove.Parameters.AddWithValue("@pos", hurrengoPos);
                cmdMove.ExecuteNonQuery();

                tx.Commit();
                MessageBox.Show("Partida eguneratua – zuhaitza ondo aurreratu da");
            }
            catch (Exception e)
            {
                tx.Rollback();
                MessageBox.Show("Errorea:\n" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}