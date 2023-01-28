using Aplikacija.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmRezultatDetails : Form
    {
        public Igrac Igrac { get { return (Igrac)cmbIgrac.SelectedItem; } set { cmbIgrac.SelectedItem = value; } }
        public VideoIgra VideoIgra { get { return (VideoIgra)cmbVideoIgra.SelectedItem; } set { cmbVideoIgra.SelectedItem = value; } }
        public Kategorija Kategorija { get { return (Kategorija)cmbKategorija.SelectedItem; } set { cmbKategorija.SelectedItem = value; } }
        public int Vreme { get { return (int)nudVreme.Value; } set { nudVreme.Value = value; } }
        public DateTime Datum { get { return dtpDatum.Value; } set { dtpDatum.Value = value; } }

        public frmRezultatDetails()
        {
            InitializeComponent();
            cmbIgrac.DataSource = GUIController.Instance.GetPlayers();
            cmbVideoIgra.DataSource = GUIController.Instance.GetGames();
            cmbKategorija.DataSource = GUIController.Instance.GetCategories();
        }

        private void cmbVideoIgra_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Kategorija> k = new List<Kategorija>();
            foreach (KategorijaIgre ki in GUIController.Instance.GetGameCategories())
                if (ki.VideoIgraID == ((VideoIgra)cmbVideoIgra.SelectedItem).VideoIgraID)
                    k.Add(GUIController.Instance.GetCategories().Single(c => c.KategorijaID == ki.KategorijaID));
            cmbKategorija.DataSource = k;
        }

        internal void DisableEditingKeyFields()
        {
            cmbIgrac.Enabled = false;
            cmbVideoIgra.Enabled = false;
            cmbKategorija.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbIgrac.SelectedItem is null)
            {
                cmbIgrac.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Igrač ne može biti prazan!", "Neisravan igrač", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbVideoIgra.SelectedItem is null)
            {
                cmbVideoIgra.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Video igra ne može biti prazna!", "Neisravna video igra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbKategorija.SelectedItem is null)
            {
                cmbKategorija.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Kategorija ne može biti prazna!", "Neisravna kategorija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}