using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmIgracDetails : Form
    {
        public string Nadimak { get { return txtNadimak.Text; } set { txtNadimak.Text = value; } }
        public int Starost { get { return (int)nudStarost.Value; } set { nudStarost.Value = value; } }

        public frmIgracDetails()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNadimak.Text))
            {
                txtNadimak.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Nadimak ne može biti prazan!", "Neisravan nadimak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}