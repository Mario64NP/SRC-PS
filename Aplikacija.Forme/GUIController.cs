using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;
using Aplikacija.Domen;
using Aplikacija.Zajednicko;

namespace Aplikacija.Forme
{
    internal class GUIController
    {
        private static GUIController _instance;
        public static GUIController Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new GUIController();

                return _instance;
            }
        }

        private Communicator communicator;
        private readonly frmLogin frmLogin;
        private readonly frmMain frmMain;
        private Igrac selectedIgrac;
        private VideoIgra selectedVideoIgra;
        private Rezultat selectedRezultat;
        private GUIController()
        {
            Connect();

            frmLogin = new frmLogin();
            HookFrmLoginEvents();

            frmMain = new frmMain();
            HookFrmMainEvents();
        }

        private void HookFrmLoginEvents()
        {
            frmLogin.LoginButton.Click += btnLogin_Click;
        }

        private void HookFrmMainEvents()
        {
            frmMain.Load += frmMain_Load;
            frmMain.BtnIgracDodaj.Click += btnIgracDodaj_Click;
            frmMain.BtnIgracPretrazi.Click += btnIgracPretrazi_Click;
            frmMain.BtnIgracIzmeni.Click += btnIgracIzmeni_Click;
            frmMain.BtnIgracObrisi.Click += btnIgracObrisi_Click;
            frmMain.BtnVideoIgraDodaj.Click += btnVideoIgraDodaj_Click;
            frmMain.BtnVideoIgraPretrazi.Click += btnVideoIgraPretrazi_Click;
            frmMain.BtnVideoIgraIzmeni.Click += btnVideoIgraIzmeni_Click;
            frmMain.BtnVideoIgraObrisi.Click += btnVideoIgraObrisi_Click;
            frmMain.BtnRezultatDodaj.Click += btnRezultatDodaj_Click;
            frmMain.BtnRezultatPretrazi.Click += btnRezultatPretrazi_Click;
            frmMain.BtnRezultatIzmeni.Click += btnRezultatIzmeni_Click;
            frmMain.BtnRezultatObrisi.Click += btnRezultatObrisi_Click;
            frmMain.DgvIgraci.CellClick += dgvIgraci_CellClick;
            frmMain.DgvVideoIgre.CellClick += dgvVideoIgre_CellClick;
            frmMain.DgvRezultati.CellClick += dgvRezultati_CellClick;
        }

        private void RefreshDgvPlayers()
        {
            frmMain.DgvIgraci.DataSource = null;
            frmMain.DgvIgraci.DataSource = GetPlayers();
            frmMain.DgvIgraci.Columns[0].Visible = false;
            frmMain.DgvIgraci.Columns[3].Visible = false;
            frmMain.DgvIgraci.Columns[4].Visible = false;
            frmMain.DgvIgraci.Columns[5].Visible = false;
            frmMain.DgvIgraci.Columns[6].Visible = false;
            frmMain.DgvIgraci.Columns[7].Visible = false;
        }

        private void RefreshDgvGames()
        {
            frmMain.DgvVideoIgre.DataSource = null;
            frmMain.DgvVideoIgre.DataSource = GetGames();
            frmMain.DgvVideoIgre.Columns[0].Visible = false;
            frmMain.DgvVideoIgre.Columns[5].Visible = false;
            frmMain.DgvVideoIgre.Columns[6].Visible = false;
            frmMain.DgvVideoIgre.Columns[7].Visible = false;
            frmMain.DgvVideoIgre.Columns[8].Visible = false;
            frmMain.DgvVideoIgre.Columns[9].Visible = false;
        }

        private void RefreshDgvResults()
        {
            frmMain.DgvRezultati.DataSource = null;
            frmMain.DgvRezultati.DataSource = GetResults();
            frmMain.DgvRezultati.Columns[5].Visible = false;
            frmMain.DgvRezultati.Columns[6].Visible = false;
            frmMain.DgvRezultati.Columns[7].Visible = false;
            frmMain.DgvRezultati.Columns[8].Visible = false;
            frmMain.DgvRezultati.Columns[9].Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshDgvPlayers();
            RefreshDgvGames();
            RefreshDgvResults();
        }

        private void Connect()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect("127.0.0.1", 9988);
            communicator = new Communicator(s);
        }

        internal void Start()
        {
            if (frmLogin.ShowDialog() != DialogResult.OK)
                return;

            frmMain.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TryLogin(new User(frmLogin.UsernameTBox.Text, frmLogin.PasswordTBox.Text)))
                frmLogin.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Your username/password combination is not correct. Try again.", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool TryLogin(User u)
        {
            Request r = new Request { Operation = Operation.Login, Argument = u };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
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

                if (AddPlayer(i))
                {
                    RefreshDgvPlayers();
                    MessageBox.Show("Sistem je zapamtio igrača.", "Dodavanje igrača", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti igrača.", "Dodavanje igrača", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIgracPretrazi_Click(object sender, EventArgs e)
        {
            List<Igrac> result = SearchPlayers(frmMain.TxtPlayersSearch.Text);
            if (result.Count > 0)
                frmMain.DgvIgraci.DataSource = result;
            else
                MessageBox.Show("Sistem ne može da pronađe igrače po zadatoj vrednosti.", "Pretraga igrača", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIgracIzmeni_Click(object sender, EventArgs e)
        {
            frmIgracDetails frm = new frmIgracDetails();
            frm.Text = "Izmeni igrača";
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

                if (UpdatePlayer(i))
                {
                    RefreshDgvPlayers();
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio igrača.", "Izmena igrača", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti igrača.", "Izmena igrača", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIgracObrisi_Click(object sender, EventArgs e)
        {
            if (selectedIgrac != null && DeletePlayer(selectedIgrac))
            {
                RefreshDgvPlayers();
                RefreshDgvResults();

                selectedIgrac = null;
                selectedRezultat = null;
                frmMain.BtnIgracIzmeni.Enabled = false;
                frmMain.BtnIgracObrisi.Enabled = false;

                MessageBox.Show("Sistem je obrisao igrača.", "Brisanje igrača", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sistem ne može da obriše igrača.", "Brisanje igrača", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnVideoIgraDodaj_Click(object sender, EventArgs e)
        {
            frmVideoIgraDetails frm = new frmVideoIgraDetails();
            frm.Text = "Dodaj video igru";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                VideoIgra v = new VideoIgra
                {
                    Naziv = frm.Naziv,
                    Izdavac = frm.Izdavac,
                    GodinaIzdanja = frm.GodinaIzdanja,
                    Platforma = frm.Platforma
                };

                List<Kategorija> k = new List<Kategorija>();
                foreach (var item in GetCategories())
                    if (frm.LvGameCategories.SelectedItems.ContainsKey(item.Naziv))
                        k.Add(item);

                if (AddGame(v, k))
                {
                    RefreshDgvGames();
                    MessageBox.Show("Sistem je zapamtio video igru.", "Dodavanje video igre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti video igru.", "Dodavanje video igre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVideoIgraPretrazi_Click(object sender, EventArgs e)
        {
            List<VideoIgra> result = SearchGames(frmMain.TxtGamesSearch.Text);
            if (result.Count > 0)
                frmMain.DgvVideoIgre.DataSource = result;
            else
                MessageBox.Show("Sistem ne može da pronađe video igre po zadatoj vrednosti.", "Pretraga video igara", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnVideoIgraIzmeni_Click(object sender, EventArgs e)
        {
            frmVideoIgraDetails frm = new frmVideoIgraDetails();
            frm.Text = "Izmeni video igru";
            frm.Naziv = selectedVideoIgra.Naziv;
            frm.Izdavac = selectedVideoIgra.Izdavac;
            frm.GodinaIzdanja = selectedVideoIgra.GodinaIzdanja;
            frm.Platforma = selectedVideoIgra.Platforma;

            List<KategorijaIgre> gc = GetGameCategories();
            foreach (KategorijaIgre k in gc)
            {
                if (k.VideoIgraID == selectedVideoIgra.VideoIgraID)
                {
                    frm.LvGameCategories.Items[k.KategorijaID-2].Focused = true;
                    frm.LvGameCategories.Items[k.KategorijaID-2].Selected = true;
                }
            }
            frm.LvGameCategories.Select();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                VideoIgra v = new VideoIgra
                {
                    VideoIgraID = selectedVideoIgra.VideoIgraID,
                    Naziv = frm.Naziv,
                    Izdavac = frm.Izdavac,
                    GodinaIzdanja = frm.GodinaIzdanja,
                    Platforma = frm.Platforma
                };

                List<Kategorija> k = new List<Kategorija>();
                foreach (var item in GetCategories())
                    if (frm.LvGameCategories.SelectedItems.ContainsKey(item.Naziv))
                        k.Add(item);

                if (UpdateGame(v, k))
                {
                    RefreshDgvGames();
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio video igru.", "Izmena video igre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti video igru.", "Izmena video igre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVideoIgraObrisi_Click(object sender, EventArgs e)
        {
            if (selectedVideoIgra != null && DeleteGame(selectedVideoIgra))
            {
                RefreshDgvGames();
                RefreshDgvResults();

                selectedVideoIgra = null;
                selectedRezultat = null;
                frmMain.BtnVideoIgraIzmeni.Enabled = false;
                frmMain.BtnVideoIgraObrisi.Enabled = false;

                MessageBox.Show("Sistem je obrisao video igru.", "Brisanje video igre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sistem ne može da obriše video igru.", "Brisanje video igre", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRezultatDodaj_Click(object sender, EventArgs e)
        {
            frmRezultatDetails frm = new frmRezultatDetails();
            frm.Text = "Dodaj rezultat";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Rezultat r = new Rezultat
                {
                    Igrac = frm.Igrac,
                    VideoIgra = frm.VideoIgra,
                    Kategorija = frm.Kategorija,
                    Vreme = frm.Vreme,
                    Datum = frm.Datum
                };

                if (AddResult(r))
                {
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio rezultat.", "Dodavanje rezultata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti rezultat.", "Dodavanje rezultata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezultatPretrazi_Click(object sender, EventArgs e)
        {
            List<Rezultat> result = SearchResults(frmMain.TxtResultsSearch.Text);
            if (result.Count > 0)
                frmMain.DgvRezultati.DataSource = result;
            else
                MessageBox.Show("Sistem ne može da pronađe rezultate po zadatoj vrednosti.", "Pretraga rezultata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRezultatIzmeni_Click(object sender, EventArgs e)
        {
            frmRezultatDetails frm = new frmRezultatDetails();
            frm.Text = "Izmena rezultata";
            frm.Igrac = selectedRezultat.Igrac;
            frm.VideoIgra = selectedRezultat.VideoIgra;
            frm.Kategorija = selectedRezultat.Kategorija;
            frm.Vreme = selectedRezultat.Vreme;
            frm.Datum = selectedRezultat.Datum;
            frm.DisableEditingKeyFields();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Rezultat r = new Rezultat
                {
                    Igrac = new Igrac { IgracID = selectedRezultat.Igrac.IgracID },
                    VideoIgra = new VideoIgra { VideoIgraID = selectedRezultat.VideoIgra.VideoIgraID },
                    Kategorija = new Kategorija { KategorijaID = selectedRezultat.Kategorija.KategorijaID },
                    Vreme = frm.Vreme,
                    Datum = frm.Datum
                };

                if (UpdateResult(r))
                {
                    RefreshDgvResults();
                    MessageBox.Show("Sistem je zapamtio rezultat.", "Izmena rezultata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sistem ne može da zapamti rezultat.", "Izmena rezultata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezultatObrisi_Click(object sender, EventArgs e)
        {
            if (selectedRezultat != null && DeleteResult(selectedRezultat))
            {
                RefreshDgvResults();

                selectedRezultat = null;
                frmMain.BtnRezultatIzmeni.Enabled = false;
                frmMain.BtnRezultatObrisi.Enabled = false;

                MessageBox.Show("Sistem je obrisao rezultat.", "Brisanje rezultata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sistem ne može da obriše rezultat.", "Brisanje rezultata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvIgraci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIgrac = (Igrac)frmMain.DgvIgraci.Rows[e.RowIndex].DataBoundItem;
            frmMain.BtnIgracIzmeni.Enabled = true;
            frmMain.BtnIgracObrisi.Enabled = true;
        }

        private void dgvVideoIgre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedVideoIgra = (VideoIgra)frmMain.DgvVideoIgre.Rows[e.RowIndex].DataBoundItem;
            frmMain.BtnVideoIgraIzmeni.Enabled = true;
            frmMain.BtnVideoIgraObrisi.Enabled = true;
        }

        private void dgvRezultati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRezultat = (Rezultat)frmMain.DgvRezultati.Rows[e.RowIndex].DataBoundItem;
            frmMain.BtnRezultatIzmeni.Enabled = true;
            frmMain.BtnRezultatObrisi.Enabled = true;
        }

        public List<Igrac> GetPlayers()
        {
            Request r = new Request { Operation = Operation.GetPlayers };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Igrac>)res.Result;
        }

        public List<Igrac> SearchPlayers(string criterion)
        {
            Request r = new Request { Operation = Operation.SearchPlayers, Argument = criterion };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Igrac>)res.Result;
        }

        public bool AddPlayer(Igrac i)
        {
            Request r = new Request { Operation = Operation.AddPlayer, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool UpdatePlayer(Igrac i)
        {
            Request r = new Request { Operation = Operation.UpdatePlayer, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool DeletePlayer(Igrac i)
        {
            Request r = new Request { Operation = Operation.DeletePlayer, Argument = i };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<VideoIgra> GetGames()
        {
            Request r = new Request { Operation = Operation.GetGames };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<VideoIgra>)res.Result;
        }

        public List<VideoIgra> SearchGames(string criterion)
        {
            Request r = new Request { Operation = Operation.SearchGames, Argument = criterion };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<VideoIgra>)res.Result;
        }

        public bool AddGame(VideoIgra v, List<Kategorija> k)
        {
            Request r = new Request { Operation = Operation.AddGame, Argument = (v, k) };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool UpdateGame(VideoIgra v, List<Kategorija> k)
        {
            Request r = new Request { Operation = Operation.UpdateGame, Argument = (v, k) };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool DeleteGame(VideoIgra v)
        {
            Request r = new Request { Operation = Operation.DeleteGame, Argument = v };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<Rezultat> GetResults()
        {
            Request r = new Request { Operation = Operation.GetResults };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Rezultat>)res.Result;
        }

        public List<Rezultat> SearchResults(string criterion)
        {
            Request request = new Request { Operation = Operation.SearchResults, Argument = criterion };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (List<Rezultat>)res.Result;
        }

        public bool AddResult(Rezultat r)
        {
            Request request = new Request { Operation = Operation.AddResult, Argument = r };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool UpdateResult(Rezultat v)
        {
            Request request = new Request { Operation = Operation.UpdateResult, Argument = v };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public bool DeleteResult(Rezultat r)
        {
            Request request = new Request { Operation = Operation.DeleteResult, Argument = r };
            communicator.Send(request);
            Response res = communicator.Receive<Response>();

            return (bool)res.Result;
        }

        public List<Platforma> GetPlatforms()
        {
            Request r = new Request { Operation = Operation.GetPlatforms };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Platforma>)res.Result;
        }

        public List<Kategorija> GetCategories()
        {
            Request r = new Request { Operation = Operation.GetCategories };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<Kategorija>)res.Result;
        }

        public List<KategorijaIgre> GetGameCategories()
        {
            Request r = new Request { Operation = Operation.GetGameCategories };
            communicator.Send(r);
            Response res = communicator.Receive<Response>();

            return (List<KategorijaIgre>)res.Result;
        }
    }
}