using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmMain : Form
    {
        internal DataGridView DgvIgraci { get => dgvIgraci; }
        internal DataGridView DgvVideoIgre { get => dgvVideoIgre; }
        internal DataGridView DgvRezultati { get => dgvRezultati; }
        internal Button BtnIgracDodaj { get => btnIgracDodaj; }
        internal Button BtnIgracPretrazi { get => btnIgracPretrazi; }
        internal Button BtnIgracIzmeni { get => btnIgracIzmeni; }
        internal Button BtnIgracObrisi { get => btnIgracObrisi; }
        internal Button BtnVideoIgraDodaj { get => btnVideoIgraDodaj; }
        internal Button BtnVideoIgraPretrazi { get => btnVideoIgraPretrazi; }
        internal Button BtnVideoIgraIzmeni { get => btnVideoIgraIzmeni; }
        internal Button BtnVideoIgraObrisi { get => btnVideoIgraObrisi; }
        internal Button BtnRezultatDodaj { get => btnRezultatDodaj; }
        internal Button BtnRezultatPretrazi { get => btnRezultatPretrazi; }
        internal Button BtnRezultatIzmeni { get => btnRezultatIzmeni; }
        internal Button BtnRezultatObrisi { get => btnRezultatObrisi; }
        internal TextBox TxtPlayersSearch { get => txtPlayersSearch; }
        internal TextBox TxtGamesSearch { get => txtGamesSearch; }
        internal TextBox TxtResultsSearch { get => txtResultsSearch; }

        public frmMain()
        {
            InitializeComponent();

            btnIgracIzmeni.Enabled = false;
            btnIgracObrisi.Enabled = false;
            btnVideoIgraIzmeni.Enabled = false;
            btnVideoIgraObrisi.Enabled = false;
            btnRezultatIzmeni.Enabled = false;
            btnRezultatObrisi.Enabled = false;
        }
    }
}