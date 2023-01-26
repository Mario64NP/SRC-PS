using Aplikacija.Domen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmMain : Form
    {
        internal DataGridView DgvIgraci { get { return dgvIgraci; } }
        internal DataGridView DgvVideoIgre { get { return dgvVideoIgre; } }
        internal DataGridView DgvRezultati { get { return dgvRezultati; } }
        private Igrac selectedIgrac;
        private VideoIgra selectedVideoIgra;
        private Rezultat selectedRezultat;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshDgvPlayers();
            RefreshDgvGames();
            RefreshDgvResults();
        }

        private void RefreshDgvPlayers()
        {
            dgvIgraci.DataSource = null;
            dgvIgraci.DataSource = GUIController.Instance.GetPlayers();
            dgvIgraci.Columns[3].Visible = false;
            dgvIgraci.Columns[4].Visible = false;
            dgvIgraci.Columns[5].Visible = false;
            dgvIgraci.Columns[6].Visible = false;
            dgvIgraci.Columns[7].Visible = false;
        }

        private void RefreshDgvGames()
        {
            dgvVideoIgre.DataSource = null;
            dgvVideoIgre.DataSource = GUIController.Instance.GetGames();
            dgvVideoIgre.Columns[5].Visible = false;
            dgvVideoIgre.Columns[6].Visible = false;
            dgvVideoIgre.Columns[7].Visible = false;
            dgvVideoIgre.Columns[8].Visible = false;
            dgvVideoIgre.Columns[9].Visible = false;
        }

        private void RefreshDgvResults()
        {
            dgvRezultati.DataSource = null;
            dgvRezultati.DataSource = GUIController.Instance.GetResults();
            dgvRezultati.Columns[5].Visible = false;
            dgvRezultati.Columns[6].Visible = false;
            dgvRezultati.Columns[7].Visible = false;
            dgvRezultati.Columns[8].Visible = false;
            dgvRezultati.Columns[9].Visible = false;
        }

        private void btnIgracDodaj_Click(object sender, EventArgs e)
        {
            
            frmIgracDetails frm = new frmIgracDetails();
            frm.Text = "Dodaj igrača";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Igrac i = new Igrac
                {
                    Nadimak = frm.Nadimak,
                    Starost = frm.Starost
                };

                if (GUIController.Instance.AddPlayer(i))
                {
                    RefreshDgvPlayers();
                    MessageBox.Show("Sistem je zapamtio igrača.");
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti igrača.");
            }
        }

        private void btnIgracPretrazi_Click(object sender, EventArgs e)
        {
            frmIgracDetails frm = new frmIgracDetails();
            frm.Text = "Pretraga igrača";
            frm.ChbNadimak.Visible = true;
            frm.ChbStarost.Visible = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Igrac i = new Igrac();
                if (frm.ChbNadimak.Checked) i.Nadimak = frm.Nadimak;
                if (frm.ChbStarost.Checked) i.Starost = frm.Starost;

                List<Igrac> result = GUIController.Instance.SearchPlayers(i);
                if (result.Count > 0)
                    dgvIgraci.DataSource = result;
                else
                    MessageBox.Show("Sistem ne može da pronađe igrače po zadatoj vrednosti.");
            }
        }

        private void btnIgracIzmeni_Click(object sender, EventArgs e)
        {
            frmIgracDetails frm = new frmIgracDetails();
            frm.Text    = "Izmeni igrača";
            frm.Nadimak = selectedIgrac.Nadimak;
            frm.Starost = selectedIgrac.Starost;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Igrac i = new Igrac
                {
                    IgracID = selectedIgrac.IgracID,
                    Nadimak = frm.Nadimak,
                    Starost = frm.Starost
                };

                if (GUIController.Instance.UpdatePlayer(i))
                {
                    RefreshDgvPlayers();
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio igrača.");
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti igrača.");
            }
        }

        private void btnIgracObrisi_Click(object sender, EventArgs e)
        {
            if (selectedIgrac != null && GUIController.Instance.DeletePlayer(selectedIgrac))
            {
                RefreshDgvPlayers();
                RefreshDgvResults();
                
                selectedIgrac = null;
                selectedRezultat = null;
                btnIgracIzmeni.Enabled = false;
                btnIgracObrisi.Enabled = false;

                MessageBox.Show("Sistem je obrisao igrača.");
            }
            else
                MessageBox.Show("Sistem ne može da obriše igrača.");
        }

        private void btnVideoIgraDodaj_Click(object sender, EventArgs e)
        {
            frmVideoIgraDetails frm = new frmVideoIgraDetails();
            frm.Text = "Dodaj video igru";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                VideoIgra v = new VideoIgra
                {
                    Naziv         = frm.Naziv,
                    Izdavac       = frm.Izdavac,
                    GodinaIzdanja = frm.GodinaIzdanja,
                    Platforma     = frm.Platforma
                };

                if (GUIController.Instance.AddGame(v))
                {
                    RefreshDgvGames();
                    MessageBox.Show("Sistem je zapamtio video igru.");
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti video igru.");
            }
        }

        private void btnVideoIgraPretrazi_Click(object sender, EventArgs e)
        {
            frmVideoIgraDetails frm = new frmVideoIgraDetails();
            frm.Text = "Pretraga video igara";
            frm.ChbNaziv.Visible = true;
            frm.ChbIzdavac.Visible = true;
            frm.ChbGodinaIzdanja.Visible = true;
            frm.ChbPlatforma.Visible = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                VideoIgra v = new VideoIgra();
                if (frm.ChbNaziv.Checked)         v.Naziv         = frm.Naziv;
                if (frm.ChbIzdavac.Checked)       v.Izdavac       = frm.Izdavac;
                if (frm.ChbGodinaIzdanja.Checked) v.GodinaIzdanja = frm.GodinaIzdanja;
                if (frm.ChbPlatforma.Checked)     v.Platforma     = frm.Platforma;

                List<VideoIgra> result = GUIController.Instance.SearchGames(v);
                if (result.Count > 0)
                    dgvVideoIgre.DataSource = result;
                else
                    MessageBox.Show("Sistem ne može da pronađe video igre po zadatoj vrednosti.");
            }
        }

        private void btnVideoIgraIzmeni_Click(object sender, EventArgs e)
        {
            frmVideoIgraDetails frm = new frmVideoIgraDetails();
            frm.Text          = "Izmeni video igru";
            frm.Naziv         = selectedVideoIgra.Naziv;
            frm.Izdavac       = selectedVideoIgra.Izdavac;
            frm.GodinaIzdanja = selectedVideoIgra.GodinaIzdanja;
            frm.Platforma     = selectedVideoIgra.Platforma;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                VideoIgra v = new VideoIgra
                {
                    VideoIgraID   = selectedVideoIgra.VideoIgraID,
                    Naziv         = frm.Naziv,
                    Izdavac       = frm.Izdavac,
                    GodinaIzdanja = frm.GodinaIzdanja,
                    Platforma     = frm.Platforma
                };

                if (GUIController.Instance.UpdateGame(v))
                {
                    RefreshDgvGames();
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio video igru.");
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti video igru.");
            }
        }

        private void btnVideoIgraObrisi_Click(object sender, EventArgs e)
        {
            if (selectedVideoIgra != null && GUIController.Instance.DeleteGame(selectedVideoIgra))
            {
                RefreshDgvGames();
                RefreshDgvResults();

                selectedVideoIgra = null;
                selectedRezultat = null;
                btnVideoIgraIzmeni.Enabled = false;
                btnVideoIgraObrisi.Enabled = false;

                MessageBox.Show("Sistem je obrisao video igru.");
            }
            else
                MessageBox.Show("Sistem ne može da obriše video igru.");
        }

        private void btnRezultatDodaj_Click(object sender, EventArgs e)
        {
            frmRezultatDetails frm = new frmRezultatDetails();
            frm.Text = "Dodaj rezultat";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Rezultat r = new Rezultat
                {
                    Igrac      = frm.Igrac,
                    VideoIgra  = frm.VideoIgra,
                    Kategorija = frm.Kategorija,
                    Vreme      = frm.Vreme,
                    Datum      = frm.Datum
                };

                if (GUIController.Instance.AddResult(r))
                {
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio rezultat.");
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti rezultat.");
            }
        }

        private void btnRezultatPretrazi_Click(object sender, EventArgs e)
        {
            frmRezultatDetails frm = new frmRezultatDetails();
            frm.Text = "Pretraga rezultata";
            frm.ChbIgrac.Visible = true;
            frm.ChbVideoIgra.Visible = true;
            frm.ChbKategorija.Visible = true;
            frm.ChbVreme.Visible = true;
            frm.ChbDatum.Visible = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Rezultat r = new Rezultat();
                if (frm.ChbIgrac.Checked)      r.Igrac      = frm.Igrac;
                if (frm.ChbVideoIgra.Checked)  r.VideoIgra  = frm.VideoIgra;
                if (frm.ChbKategorija.Checked) r.Kategorija = frm.Kategorija;
                if (frm.ChbVreme.Checked)      r.Vreme      = frm.Vreme;
                if (frm.ChbDatum.Checked)      r.Datum      = frm.Datum;


                List<Rezultat> result = GUIController.Instance.SearchResults(r);
                if (result.Count > 0)
                    dgvRezultati.DataSource = result;
                else
                    MessageBox.Show("Sistem ne može da pronađe rezultate po zadatoj vrednosti.");
            }
        }

        private void btnRezultatIzmeni_Click(object sender, EventArgs e)
        {
            frmRezultatDetails frm = new frmRezultatDetails();
            frm.Text       = "Izmena rezultata";
            frm.Igrac      = selectedRezultat.Igrac;
            frm.VideoIgra  = selectedRezultat.VideoIgra;
            frm.Kategorija = selectedRezultat.Kategorija;
            frm.Vreme      = selectedRezultat.Vreme;
            frm.Datum      = selectedRezultat.Datum;
            frm.DisableEditingKeyFields();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Rezultat r = new Rezultat
                {
                    Igrac      = new Igrac { IgracID = selectedRezultat.Igrac.IgracID },
                    VideoIgra  = new VideoIgra { VideoIgraID = selectedRezultat.VideoIgra.VideoIgraID },
                    Kategorija = new Kategorija { KategorijaID = selectedRezultat.Kategorija.KategorijaID },
                    Vreme      = frm.Vreme,
                    Datum      = frm.Datum
                };

                if (GUIController.Instance.UpdateResult(r))
                {
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio rezultat.");
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti rezultat.");
            }
        }

        private void btnRezultatObrisi_Click(object sender, EventArgs e)
        {
            if (selectedRezultat != null && GUIController.Instance.DeleteResult(selectedRezultat))
            {
                RefreshDgvResults();

                selectedRezultat = null;
                btnRezultatIzmeni.Enabled = false;
                btnRezultatObrisi.Enabled = false;

                MessageBox.Show("Sistem je obrisao rezultat.");
            }
            else
                MessageBox.Show("Sistem ne može da obriše rezultat.");
        }

        private void dgvIgraci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIgrac = (Igrac)dgvIgraci.Rows[e.RowIndex].DataBoundItem;
            btnIgracIzmeni.Enabled = true;
            btnIgracObrisi.Enabled = true;
        }

        private void dgvVideoIgre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedVideoIgra = (VideoIgra)dgvVideoIgre.Rows[e.RowIndex].DataBoundItem;
            btnVideoIgraIzmeni.Enabled = true;
            btnVideoIgraObrisi.Enabled = true;
        }

        private void dgvRezultati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRezultat = (Rezultat)dgvRezultati.Rows[e.RowIndex].DataBoundItem;
            btnRezultatIzmeni.Enabled = true;
            btnRezultatObrisi.Enabled = true;
        }
    }
}