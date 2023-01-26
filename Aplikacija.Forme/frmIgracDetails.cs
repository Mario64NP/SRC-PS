using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmIgracDetails : Form
    {
        public string Nadimak { get { return txtNadimak.Text; } set { txtNadimak.Text = value; } }
        public int Starost { get { return (int)nudStarost.Value; } set { nudStarost.Value = value; } }
        public CheckBox ChbNadimak { get { return chbNadimak; } }
        public CheckBox ChbStarost { get { return chbStarost; } }
        public frmIgracDetails()
        {
            InitializeComponent();
        }

        private void chbNadimak_CheckedChanged(object sender, System.EventArgs e)
        {
            txtNadimak.Enabled = chbNadimak.Checked;
        }

        private void chbStarost_CheckedChanged(object sender, System.EventArgs e)
        {
            nudStarost.Enabled = chbStarost.Checked;
        }
    }
}
