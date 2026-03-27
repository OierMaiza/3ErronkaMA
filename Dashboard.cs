using System.Drawing;
using System.Windows.Forms;

namespace EuskalMus
{
    public partial class Dashboard : Form
    {
        // ── Campos declarados a nivel de clase (fuera del constructor) ──
        private Panel pnlGoikoBarra;
        private Label lblLogo;
        private Label lblUser;
        private Button btnTxapelketak;
        private Button btnJokalariak;
        private Button btnBikoteak;
        private Button btnZozketa;
        private Button btnPartidak;

        // ── Constructor ──────────────────────────────────────────────────
        public Dashboard(string izena, string abizena, string rola)
        {
            InitializeComponent();

            // Mostrar el usuario en la barra superior
            lblUser.Text = izena + " " + abizena + " (" + rola + ")";
        }
    }
}