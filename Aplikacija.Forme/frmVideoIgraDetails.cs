using Aplikacija.Domen;
using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmVideoIgraDetails : Form
    {
        public string Naziv { get { return txtNaziv.Text; } set { txtNaziv.Text = value; } }
        public string Izdavac { get { return txtIzdavac.Text; } set { txtIzdavac.Text = value; } }
        public int GodinaIzdanja { get { return (int)nudGodinaIzdanja.Value; } set { nudGodinaIzdanja.Value = value; } }
        public Platforma Platforma { get { return (Platforma)cmbPlatforma.SelectedItem; } set { cmbPlatforma.SelectedItem = value; } }

        public CheckBox ChbNaziv { get { return chbNaziv; } }
        public CheckBox ChbIzdavac { get { return chbIzdavac; } }
        public CheckBox ChbGodinaIzdanja { get { return chbGodinaIzdanja; } }
        public CheckBox ChbPlatforma { get { return chbPlatforma; } }
        public frmVideoIgraDetails()
        {
            InitializeComponent();
            cmbPlatforma.DataSource = GUIController.Instance.GetPlatforms();
        }

        private void chbNaziv_CheckedChanged(object sender, System.EventArgs e)
        {
            txtNaziv.Enabled = chbNaziv.Checked;
        }

        private void chbIzdavac_CheckedChanged(object sender, System.EventArgs e)
        {
            txtIzdavac.Enabled = chbIzdavac.Checked;
        }

        private void chbGodinaIzdanja_CheckedChanged(object sender, System.EventArgs e)
        {
            nudGodinaIzdanja.Enabled = chbGodinaIzdanja.Checked;
        }

        private void chbPlatforma_CheckedChanged(object sender, System.EventArgs e)
        {
            cmbPlatforma.Enabled = chbPlatforma.Checked;
        }
    }
}