using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuskalMus
{
    public class Konexioa
    {
        private static string url = "Server=localhost;Port=3306;Database=3erronka;Uid=root;Pwd=1MG32025;SslMode=Disabled;";
        public MySqlConnection getConnection()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(url);
                con.Open();
                MessageBox.Show("MySQL konexioa eginda", "Konexioa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Konexio errorea:\n" + e.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
