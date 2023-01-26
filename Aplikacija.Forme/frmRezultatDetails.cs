using Aplikacija.Domen;
using System;
using System.Collections.Generic;
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
        public CheckBox ChbIgrac { get { return chbIgrac; } }
        public CheckBox ChbVideoIgra { get { return chbVideoIgra; } }
        public CheckBox ChbKategorija { get { return chbKategorija; } }
        public CheckBox ChbVreme { get { return chbVreme; } }
        public CheckBox ChbDatum { get { return chbDatum; } }
        public frmRezultatDetails()
        {
            InitializeComponent();
            cmbIgrac.DataSource = GUIController.Instance.GetPlayers();
            cmbVideoIgra.DataSource = GUIController.Instance.GetGames();
            cmbKategorija.DataSource = GUIController.Instance.GetCategories();
        }

        private void cmbVideoIgra_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            List<Kategorija> k = new List<Kategorija>();
            foreach (KategorijaIgre ki in Kontroler.Kontroler.Instance.KategorijeZaIgre)
                if (ki.VideoIgraID == ((VideoIgra)cmbVideoIgra.SelectedItem).VideoIgraID)
                    k.Add(Kontroler.Kontroler.Instance.GetCategoryByID(ki.KategorijaID));
            cmbKategorija.DataSource = k;
        */}

        private void chbIgrac_CheckedChanged(object sender, EventArgs e)
        {
            cmbIgrac.Enabled = chbIgrac.Checked;
        }

        private void chbVideoIgra_CheckedChanged(object sender, EventArgs e)
        {
            cmbVideoIgra.Enabled = chbVideoIgra.Checked;
        }

        private void chbKategorija_CheckedChanged(object sender, EventArgs e)
        {
            cmbKategorija.Enabled = chbKategorija.Checked;
        }

        private void chbVreme_CheckedChanged(object sender, EventArgs e)
        {
            nudVreme.Enabled = chbVreme.Checked;
        }

        private void chbDatum_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatum.Enabled = chbDatum.Checked;
        }

        internal void DisableEditingKeyFields()
        {
            cmbIgrac.Enabled = false;
            cmbVideoIgra.Enabled = false;
            cmbKategorija.Enabled = false;
        }
    }
}