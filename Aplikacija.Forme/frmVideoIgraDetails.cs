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
        public ListView LvGameCategories { get => lvGameCategories; }

        public frmVideoIgraDetails()
        {
            InitializeComponent();
            cmbPlatforma.DataSource = GUIController.Instance.GetPlatforms();

            FillListViewCategories();
        }

        private void FillListViewCategories()
        {
            foreach (Kategorija k in GUIController.Instance.GetCategories())
                lvGameCategories.Items.Add(new ListViewItem(new string[] { k.Naziv, k.Opis}) { Name = k.Naziv});
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                txtNaziv.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Naziv ne može biti prazan!", "Neisravan naziv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtIzdavac.Text))
            {
                txtIzdavac.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Izdavač ne može biti prazan!", "Neisravan izdavač", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbPlatforma.SelectedItem is null)
            {
                cmbPlatforma.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Platforma ne može biti prazna!", "Neisravna platforma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}